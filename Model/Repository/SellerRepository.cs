using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinimarketApp.Model.Context;
using System.Data.SQLite;
using MinimarketApp.Model.Entity;

namespace MinimarketApp.Model.Repository
{
    public class SellerRepository
    {
        public SQLiteConnection _conn;
        public SellerRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public int Create(Entity.Seller item)
        {
            int result = 0;
            string sql = "insert into Pelanggan (kd_pelanggan, nama, password, umur, nohp) VALUES  (@Kdseller, @nama, @pass, @umur, @nohp)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Kdseller", item.KdSeller);
                cmd.Parameters.AddWithValue("@nama", item.Nama);
                cmd.Parameters.AddWithValue("@pass", item.Pass);
                cmd.Parameters.AddWithValue("@umur", item.Umur);
                cmd.Parameters.AddWithValue("@nohp", item.Nohp);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);

                }

            }
            return result;
        }


        public int Update(Entity.Seller item)
        {
            int result = 0;
            string sql = "update Pelanggan set nama=@Nama, password=@Pass, umur=@Umur,nohp=@Nohp WHERE kd_pelanggan=@Kdseller";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Kdseller", item.KdSeller);
                cmd.Parameters.AddWithValue("@Nama", item.Nama);
                cmd.Parameters.AddWithValue("@Pass", item.Pass);
                cmd.Parameters.AddWithValue("@Umur", item.Umur);
                cmd.Parameters.AddWithValue("@Nohp", item.Nohp);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);

                }

            }
            return result;
        }
        public int Delete(Entity.Seller item)
        {
            int result = 0;
            string sql = "Delete from Pelanggan WHERE kd_pelanggan=@KdSeller";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KdSeller", item.KdSeller);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);

                }

            }
            return result;
        }
        public List<Entity.Seller> ReadAll()
        {
            var items = new List<Entity.Seller>();
            // deklarasi perintah SQL
            string sql = @"SELECT * FROM Pelanggan";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var item = new Entity.Seller()
                        {
                            KdSeller = Convert.ToInt32(dtr["kd_pelanggan"]),
                            Nama = dtr["nama"].ToString(),
                            Pass = dtr["password"].ToString(),
                            Umur = Convert.ToInt32(dtr["umur"]),
                            Nohp = Convert.ToInt32(dtr["nohp"]),
                        };
                        items.Add(item);
                    }
                }
            }

            return items;
        }
        public List<Entity.Seller> ReadByNama(string nama)
        {
            var items = new List<Entity.Seller>();
            // deklarasi perintah SQL
            string sql = "select * from Pelanggan where nama=@nama";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama", nama);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var item = new Entity.Seller()
                        {
                            KdSeller = Convert.ToInt32(dtr["kd_pelanggan"]),
                            Nama = dtr["nama"].ToString(),
                            Pass = dtr["password"].ToString(),
                            Umur = Convert.ToInt32(dtr["umur"]),
                            Nohp = Convert.ToInt32(dtr["nohp"]),
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }
    }
}
