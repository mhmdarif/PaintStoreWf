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
    public partial class FormCompletedTransaction : Form
    {
        CartService newCart = new CartService();
        BuyerService newBuyer = new BuyerService();

        public FormCompletedTransaction()
        {
            InitializeComponent();
            lbl_totalCost.Text = newCart.GetCartTotalCost().ToString();
            lbl_BuyerName.Text = newBuyer.GetBuyerName() ;

            double totalCost = newCart.GetCartTotalCost();
            double buyerMoney = newBuyer.GetBuyerMoney();
            lbl_BuyerMoney.Text = buyerMoney.ToString();
            lbl_Changes.Text = BuyerService.getChanges(buyerMoney, totalCost).ToString();

        }


    }
}
