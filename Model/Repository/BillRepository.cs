using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimarketApp.Model.Context;
using System.Data.SQLite;

namespace MinimarketApp.Model.Repository
{
    public class BillRepository
    {
        public SQLiteConnection _conn;
        public BillRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public int Create(Entity.Bill item)
        {
            int result = 0;
            string sql = "insert into Struk (kd_struk, nama_barang, jumlah_barang, harga_barang, total) VALUES (@Kdstruk, @nama, @jumlah, @harga, @total)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Kdstruk", item.KdBill);
                cmd.Parameters.AddWithValue("@nama", item.NamaBrg);
                cmd.Parameters.AddWithValue("@jumlah", item.JumlahBrg);
                cmd.Parameters.AddWithValue("@harga", item.HargaBrg);
                cmd.Parameters.AddWithValue("@total", item.Total);
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


        public int Update(Entity.Bill item)
        {
            int result = 0;
            string sql = "update Struk set nama_barang=@nama, harga_barang=@harga, jumlah_barang=@jumlah, total=@total WHERE kd_struk=@Kdstruk";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Kdstruk", item.KdBill);
                cmd.Parameters.AddWithValue("@nama", item.NamaBrg);
                cmd.Parameters.AddWithValue("@harga", item.HargaBrg);
                cmd.Parameters.AddWithValue("@jumlah", item.JumlahBrg);
                cmd.Parameters.AddWithValue("@total", item.Total);

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
        public int Delete(Entity.Bill item)
        {
            int result = 0;
            string sql = "Delete from Struk WHERE kd_struk=@Kdstruk";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Kdstruk", item.KdBill);

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
        public List<Entity.Bill> ReadAll()
        {
            var items = new List<Entity.Bill>();
            // deklarasi perintah SQL
            string sql = @"SELECT * FROM Struk";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var item = new Entity.Bill()
                        {
                        KdBill = Convert.ToInt32(dtr["kd_struk"]),
                        NamaBrg = dtr["nama_barang"].ToString(),
                        HargaBrg = Convert.ToInt32(dtr["harga_barang"]),
                        JumlahBrg = Convert.ToInt32(dtr["jumlah_barang"]),
                        Total = Convert.ToInt32(dtr["total"])
                        };
                        items.Add(item);
                    }
                }
            }

            return items;
        }
        public List<Entity.Bill> ReadByNama(string nama)
        {
            var items = new List<Entity.Bill>();
            // deklarasi perintah SQL
            string sql = "select * from Struk where nama_barang=@nama";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama", nama);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var item = new Entity.Bill()
                        {
                            KdBill = Convert.ToInt32(dtr["kd_struk"]),
                            NamaBrg = dtr["nama_barang"].ToString(),
                            HargaBrg = Convert.ToInt32(dtr["harga_barang"]),
                            JumlahBrg = Convert.ToInt32(dtr["jumlah_barang"]),
                            Total = Convert.ToInt32(dtr["total"])
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }
    }
}
