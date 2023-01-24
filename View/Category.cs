using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MinimarketApp.Model.Entity;
using MinimarketApp.Controller;

namespace SimpleSupermarketApp
{
    public partial class Category : Form
    {
        private CategoryController controller = new CategoryController();
        private SQLiteConnection Con;
        public Category()
        {
            Con = new SQLiteConnection(@"Data Source=D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\Database\DbSupermarket.db;Version=3;");
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new MinimarketApp.Model.Entity.Category()
                {
                    KdCategory = CatIdTb.Text,
                    Nama = CatNameTb.Text,
                    Deskripsi = CatDescTb.Text,
                };
                int res = controller.Create(item);
                if (res > 0)
                {

                    MessageBox.Show("Category Berhasil Ditambahkan");
                }
                else
                {
                    MessageBox.Show("Category Gagal Ditambahkan");
                }
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void populate()
        {
            List<MinimarketApp.Model.Entity.Category> kategori = controller.ReadAll();
            CatDGV.DataSource = kategori;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "")
                {
                    MessageBox.Show("Pilih Category yang akan dihapus");
                }
                else
                {
                    var item = new MinimarketApp.Model.Entity.Category()
                    {
                        KdCategory = CatIdTb.Text,
                        Nama = CatNameTb.Text,
                        Deskripsi = CatDescTb.Text,
                    };
                    var res = controller.Delete(item);
                    if (res > 0)
                    {

                        MessageBox.Show("Category Berhasil Dihapus");
                    }
                    else
                    {
                        MessageBox.Show("Category Gagal Dihapus");
                    }
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Informasi Salah");
                }
                else
                {
                    var item = new MinimarketApp.Model.Entity.Category()
                    {
                        KdCategory = CatIdTb.Text.ToString(),
                        Nama = CatNameTb.Text.ToString(),
                        Deskripsi = CatDescTb.Text.ToString(),
                    };
                    int res = controller.Update(item);
                    if (res > 0)
                    {

                        MessageBox.Show("Category Berhasil Diupdate");
                    }
                    else
                    {
                        MessageBox.Show("Category Gagal Diupdaten");
                    }
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Main log = new Main();
            log.Show();
            this.Hide();
        }

        private void CatIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seller sell = new Seller();
            sell.Show();
            this.Hide();
        }
    }
}
