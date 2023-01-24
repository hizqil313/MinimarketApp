using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MinimarketApp.Model.Context;
using MinimarketApp.Model.Entity;
using System.Data.SQLite;

namespace MinimarketApp.Model.Repository
{
    public class CategoryRepository
    {
        public SQLiteConnection _conn;
        public CategoryRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public int Create(Entity.Category item)
        {
            int result = 0;
            string sql = "insert into Kategori(kd_kategori, nama, deskripsi) VALUES  (@KdCategory, @Nama, @Deskripsi)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KdCategory", item.KdCategory);
                cmd.Parameters.AddWithValue("@Nama", item.Nama);
                cmd.Parameters.AddWithValue("@Deskripsi", item.Deskripsi);

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


        public int Update(Entity.Category item)
        {

            string sql = @"update Kategori set nama=@Nama,deskripsi=@Deskripsi WHERE kd_kategori=@KdCategory";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KdCategory", item.KdCategory);
                cmd.Parameters.AddWithValue("@Nama", item.Nama);
                cmd.Parameters.AddWithValue("@Deskripsi", item.Deskripsi);
                return  cmd.ExecuteNonQuery();
            }

        }
        public int Delete(Entity.Category item)
        {
            int result = 0;
            var sql = "Delete from Kategori WHERE kd_kategori=@KdCategory";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@KdCategory", item.KdCategory);

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
        public List<Entity.Category> ReadAll()
        {
            var items = new List<Entity.Category>();
            // deklarasi perintah SQL
            string sql = @"SELECT * FROM Kategori";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var item = new Entity.Category()
                        {
                            KdCategory = dtr["kd_kategori"].ToString(),
                            Nama = dtr["nama"].ToString(),
                            Deskripsi = dtr["deskripsi"].ToString(),
                        };
                        items.Add(item);
                    }
                }
            }

            return items;
        }

    }
}
