using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformPaintStore.Entity;
using System.Data.SqlClient;
using winformPaintStore.View;
using winformPaintStore.Service;

namespace winformPaintStore
{
    public partial class FormHomePage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1072G2R8;Initial Catalog=paintDB;Persist Security Info=True;User ID=sa;Password=12873465");
        PaintService newPaint = new PaintService();
        CartService newCart = new CartService();
        public FormHomePage()
        {
            InitializeComponent();

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin _formAdmin = new FormAdmin();
            _formAdmin.Show();
        }

        private void btn_AddtoCart_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_paintList.CurrentRow.Cells[0].Value.ToString());
            string _Brand = "";
            string _Color = "";
            double _Price = 0;

            string sql = "select * from PaintTbl where Id = '" + id + "' ";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _Brand = dr[1].ToString();
                _Color = dr[2].ToString();
                _Price = double.Parse(dr[3].ToString());
            }
            con.Close();

            newCart.Add(_Brand, _Color, _Price);

            // update dgv
            List<PaintService> paintDgvAdmin = newPaint.GetAllPaint();
            List<CartService> cartDgvAdmin = newCart.GetAllCartItems();
            dgv_paintList.DataSource = paintDgvAdmin;
            dgv_ShoppingCart.DataSource = cartDgvAdmin;
        }

        private void dgv_paintList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_RemovefromCart_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_ShoppingCart.CurrentRow.Cells[0].Value.ToString());

            newCart.Delete(id);

            // update dgv
            List<PaintService> paintDgvAdmin = newPaint.GetAllPaint();
            List<CartService> cartDgvAdmin = newCart.GetAllCartItems();
            dgv_paintList.DataSource = paintDgvAdmin;
            dgv_ShoppingCart.DataSource = cartDgvAdmin;
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPayment _formPayment = new FormPayment();
            _formPayment.Show();
        }

        /// <summary>
        /// mencari cat berdasarkan brand pada text bos search by brand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_SearchByBrand_TextChanged(object sender, EventArgs e)
        {
            string sqlQuery = "select * from [dbo].[PaintTbl] where Brand = '"+ tb_SearchByBrand.Text+"' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgv_paintList.DataSource = dt;
            con.Close();

        }

        /// <summary>
        /// mencari cat berdasarkan Color pada text box search by color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_SearchByColor_TextChanged(object sender, EventArgs e)
        {
            string sqlQuery = "select * from [dbo].[PaintTbl] where Color = '" + tb_SearchByColor.Text + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgv_paintList.DataSource = dt;
            con.Close();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            List<PaintService> listPaints = newPaint.GetAllPaint();
            List<CartService> listCart = newCart.GetAllCartItems();
            dgv_paintList.DataSource = listPaints;
            dgv_ShoppingCart.DataSource = listCart;
        }

    }
}
