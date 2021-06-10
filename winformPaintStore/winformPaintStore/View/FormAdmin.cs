using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using winformPaintStore.Service;

namespace winformPaintStore
{
    public partial class FormAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1072G2R8;Initial Catalog=paintDB;Persist Security Info=True;User ID=sa;Password=12873465");
        PaintService newPaint = new PaintService();
        
        public FormAdmin()
        {
            InitializeComponent();
        }

        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            newPaint.Add(tb_Brand.Text, tb_Color.Text, double.Parse(tb_Price.Text));
            MessageBox.Show("Record Added");

            // update dgv
            List<PaintService> paintDgvAdmin = newPaint.GetAllPaint();
            dgv_PaintListAdmin.DataSource = paintDgvAdmin;

            //clear textbox
            clearTbox();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_PaintListAdmin.CurrentRow.Cells[0].Value.ToString());
            
            newPaint.Update(id, tb_Brand.Text, tb_Color.Text, double.Parse(tb_Price.Text));
            MessageBox.Show("Record Updated");

            // update dgv
            List<PaintService> paintDgvAdmin = newPaint.GetAllPaint();
            dgv_PaintListAdmin.DataSource = paintDgvAdmin;

            //clear textbox
            clearTbox();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_PaintListAdmin.CurrentRow.Cells[0].Value.ToString());

            newPaint.Delete(id);
            MessageBox.Show("Record Deleted");

            // update dgv
            List<PaintService> paintDgvAdmin = newPaint.GetAllPaint();
            dgv_PaintListAdmin.DataSource = paintDgvAdmin;

            //clear textbox
            clearTbox();
        }

        /// <summary>
        /// mengahapus atau mereset data pada text box
        /// </summary>
        public void clearTbox()
        {
            tb_Brand.Clear();
            tb_Color.Clear();
            tb_Price.Clear();
        }

        /// <summary>
        /// memasukan data ke dalam text bos sesuai dengan id yang di pilih
        /// </summary>
        /// <param name="id"></param>
        public void getId(int id)
        {            
            string sql = "select * from PaintTbl where Id = '" + id + "' ";
            
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tb_Brand.Text = dr[1].ToString();
                tb_Color.Text = dr[2].ToString();
                tb_Price.Text = dr[3].ToString();
            }
            con.Close();
        }

        private void dgv_PaintListAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgv_PaintListAdmin.CurrentRow.Cells[0].Value.ToString());
            getId(id);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            List<PaintService> paintDgvAdmin = newPaint.GetAllPaint();
            dgv_PaintListAdmin.DataSource = paintDgvAdmin;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomePage _from = new FormHomePage();
            _from.Show();
        }
    }
}
