using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MinimarketApp.Model.Entity;
using MinimarketApp.Model.Context;
using System.Data.SQLite;

namespace MinimarketApp.Model.Repository
{
    public class ProductRepository
    {
        public SQLiteConnection _conn;
        public ProductRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public int Create(Entity.Product item)
        {
            int result = 0;
            string sql = "insert into Produk (kd_produk, nama, jumlah, harga, kd_kategori) VALUES  (@KdProduct, @Nama, @jumlah, @harga, @KdCategory)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KdProduct", item.KdProduct);
                cmd.Parameters.AddWithValue("@Nama", item.Nama);
                cmd.Parameters.AddWithValue("@jumlah", item.Jumlah);
                cmd.Parameters.AddWithValue("@harga", item.Harga);
                cmd.Parameters.AddWithValue("@KdCategory", item.KdCategory);

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


        public int Update(Entity.Product item)
        {
            int result = 0;
            var sql = "UPDATE Produk SET nama=@Nama, jumlah=@jumlah, harga=@harga,kd_kategori=@KdCategory WHERE kd_produk=@KdProduct";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KdProduct", item.KdProduct);
                cmd.Parameters.AddWithValue("@Nama", item.Nama);
                cmd.Parameters.AddWithValue("@jumlah", item.Jumlah);
                cmd.Parameters.AddWithValue("@harga", item.Harga);
                cmd.Parameters.AddWithValue("@KdCategory", item.KdCategory);

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
        public int Delete(Entity.Product item)
        {
            int result = 0;
            var sql = "Delete from Produk WHERE kd_produk=@KdProduct";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KdProduct", item.KdProduct);

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
        public List<Entity.Product> ReadAll()
        {
            var items = new List<Entity.Product>();
            // deklarasi perintah SQL
            string sql = @"SELECT * FROM Produk";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var item = new Entity.Product()
                        {
                            KdProduct = Convert.ToInt32(dtr["kd_produk"]),
                            Nama = dtr["nama"].ToString(),
                            Jumlah = dtr["jumlah"].ToString(),
                            Harga = Convert.ToInt32(dtr["harga"]),
                            KdCategory = Convert.ToInt32(dtr["kd_kategori"]),
                        };
                        items.Add(item);
                    }
                }
            }

            return items;
        }
        public List<Entity.Product> ReadByCategory(string kategori)
        {
            var items = new List<Entity.Product>();
            // deklarasi perintah SQL
            string sql = "select * from Produk where kd_kategori=@KdCategory";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KdCategory", kategori);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var item = new Entity.Product()
                        {
                            KdProduct = Convert.ToInt32(dtr["kd_produk"]),
                            Nama = dtr["nama"].ToString(),
                            Jumlah = dtr["jumlah"].ToString(),
                            Harga = Convert.ToInt32(dtr["harga"]),
                            KdCategory = Convert.ToInt32(dtr["kd_kategori"]),
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }
        public List<Entity.Product> ReadByNama(string nama)
        {
            var items = new List<Entity.Product>();
            // deklarasi perintah SQL
            string sql = "select * from Produk where nama=@nama";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama", nama);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var item = new Entity.Product()
                        {
                            KdProduct = Convert.ToInt32(dtr["kd_produk"]),
                            Nama = dtr["nama"].ToString(),
                            Jumlah = dtr["jumlah"].ToString(),
                            Harga = Convert.ToInt32(dtr["harga"]),
                            KdCategory = Convert.ToInt32(dtr["kd_kategori"]),
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }
    }
}
