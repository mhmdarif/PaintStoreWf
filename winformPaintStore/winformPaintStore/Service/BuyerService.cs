using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using winformPaintStore.Entity;

namespace winformPaintStore.Service
{
    internal class BuyerService : Buyer, IBuyerService
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1072G2R8;Initial Catalog=paintDB;Persist Security Info=True;User ID=sa;Password=12873465");
        /// <summary>
        /// Menambahkan object Buyer ke database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="telpNumber"></param>
        /// <param name="address"></param>
        /// <param name="money"></param>
        public void Add(string name, string telpNumber, string address, double money)
        {
            string sql = "insert into BuyerTab(Name, TelpNumber, Address, Money) values('" + name + "','" + telpNumber + "','" + address + "', '" + money + "')";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// mmendapakatakn hasil kembalian dari transaksi (buyermoney - totalcost)
        /// </summary>
        /// <param name="buyerMoney"></param>
        /// <param name="totalCost"></param>
        /// <returns></returns>
        public static double getChanges(double buyerMoney, double totalCost)
        {
            double BuyerMoney = buyerMoney;
            double changes = 0;

            changes = buyerMoney - totalCost;

            return changes;
        }

        /// <summary>
        /// mendapatkan nama buyer pada record terakhir di database
        /// </summary>
        /// <returns></returns>
        public string GetBuyerName()
        {
            string buyerName = "";
            
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            cmd.Connection = con;
            cmd.CommandText = "Select Top(1) Name from BuyerTab order by Id desc ";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                buyerName = dr.GetValue(0).ToString();
            }
            con.Close();
            
            return buyerName;
        }

        /// <summary>
        /// mendapatkan nominla jumlah uang buyer dari record terakhir di database
        /// </summary>
        /// <returns></returns>
        public double GetBuyerMoney()
        {
            double buyerMoney = 0;

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            cmd.Connection = con;
            cmd.CommandText = "Select Top(1) Money from BuyerTab order by Id desc ";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                buyerMoney = (double)dr.GetValue(0);
            }
            con.Close();

            return buyerMoney;
        }
    }
}
