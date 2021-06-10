using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using winformPaintStore.Entity;

namespace winformPaintStore.Service
{
    class PaintService : Paint, IPaintService
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-1072G2R8;Initial Catalog=paintDB;Persist Security Info=True;User ID=sa;Password=12873465");
        /// <summary>
        /// menambahkan object paint ke dataabse, tabel PaintTbl
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="color"></param>
        /// <param name="price"></param>
        public void Add(string brand, string color, double price)
        {
            string sql = "insert into PaintTbl(Brand, Color, Price) values('" + brand + "','" + color + "','" + price + "')";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// mengahpus object sesuai dengan id yang dipilih
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            string sql = "delete from PaintTbl where Id = @Id";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// mengubah data object pada database, tabel PaintTbl
        /// </summary>
        /// <param name="id"></param>
        /// <param name="brand"></param>
        /// <param name="color"></param>
        /// <param name="price"></param>
        public void Update(int id, string brand, string color, double price)
        {
            string sql = "update PaintTbl set Brand = @Brand, Color = @Color, Price = @Price where Id = @id";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Brand", brand);
            cmd.Parameters.AddWithValue("@Color", color);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// memdapatkan list yang berisi semua object yang ada dalam tabel PaintTbl
        /// </summary>
        /// <returns></returns>
        public List<PaintService> GetAllPaint()
        {
            List<PaintService> lsPaint = new List<PaintService>();

            string sql = "select * from PaintTbl";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PaintService newPaint = new PaintService();

                newPaint.Id = (int)dr["id"];
                newPaint.Brand = dr["Brand"].ToString();
                newPaint.Color = dr["Color"].ToString();
                newPaint.Price = (double)dr["Price"];

                lsPaint.Add(newPaint);
            }
            con.Close();

            return lsPaint;

        }
    }
}
