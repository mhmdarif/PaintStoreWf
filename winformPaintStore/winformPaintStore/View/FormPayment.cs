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
using winformPaintStore.Service;


namespace winformPaintStore.View
{
    public partial class FormPayment : Form
    {
        CartService newCart = new CartService();
        BuyerService newBuyer = new BuyerService();

        double BuyerMoney;

        public FormPayment()
        {
            InitializeComponent();
            
            List<CartService> listCart = newCart.GetAllCartItems();
            dgv_ShoppingCartPay.DataSource = listCart;
            lbl_TotalCost.Text = newCart.GetCartTotalCost().ToString();
        }

        private void dgv_ShoppingCartPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btwn_Pay_Click(object sender, EventArgs e)
        {
            try
            {
                double buyerMoney = double.Parse(tb_BuyerMoney.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect input");
            }
            
            double totalCost = double.Parse(lbl_TotalCost.Text);

            if (BuyerMoney < 0)
            {
                MessageBox.Show("input incorrect, please try again");
            }   

            newBuyer.Add(tb_Name.Text, tb_TelpNumber.Text, tb_Address.Text, double.Parse(tb_BuyerMoney.Text));

            this.Close();
            FormCompletedTransaction _newForm = new FormCompletedTransaction();
            _newForm.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHomePage _from = new FormHomePage();
            _from.Show();
        }
    }
}
