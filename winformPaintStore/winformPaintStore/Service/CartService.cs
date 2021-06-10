using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using winformPaintStore.Entity;

namespace winformPaintStore.Service
{
    class CartService : Cart, ICartService
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1072G2R8;Initial Catalog=paintDB;Persist Security Info=True;User ID=sa;Password=12873465");
        /// <summary>
        /// menambahkan object cart ke database, tabel CartTbl
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="color"></param>
        /// <param name="price"></param>
        public void Add(string brand, string color, double price)
        {
            string sql = "insert into CartTbl(Brand, Color, Price) values('" + brand + "','" + color + "','" + price + "')";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// menghapus object cart sesuai id yang dipilih pada data grid view
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {            
            string sql = "delete from CartTbl where Id = @Id";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// mendapatkan semua object/data dalam database ke dalam list 
        /// </summary>
        /// <returns></returns>
        public List<CartService> GetAllCartItems()
        {
            List<CartService> lsCart = new List<CartService>();
            //sqlcon
            string sql = "select * from CartTbl";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CartService newCart = new CartService();

                newCart.Id = (int)dr["id"];
                newCart.Brand = dr["Brand"].ToString();
                newCart.Color = dr["Color"].ToString();
                newCart.Price = (double)dr["Price"];

                lsCart.Add(newCart);
            }
            con.Close();

            return lsCart;
        }

        /// <summary>
        /// mendapatkan hasil total biaya dari semua cat/item yang ada dalam shoppingcart
        /// </summary>
        /// <returns></returns>
        public double GetCartTotalCost()
        {
            double totalCost = 0;
            List<CartService> lsCart = new List<CartService>();
            //sqlcon
            string sql = "select * from CartTbl";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                totalCost = totalCost + (double)dr["Price"];
            }
            con.Close();

            return totalCost;
        }
    }
}
