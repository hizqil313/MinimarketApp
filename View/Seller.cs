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
    public partial class Seller : Form
    {
        private SellerController controller = new SellerController();
        private SQLiteConnection Con;

        public Seller()
        {
            Con = new SQLiteConnection(@"Data Source=D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\Database\DbSupermarket.db;Version=3;");
            InitializeComponent();
        }
        private void populate()
        {
            List<MinimarketApp.Model.Entity.Seller> pelanggan = controller.ReadAll();
            guna2DataGridView1.DataSource = pelanggan;
        }
        private void populateNama(string nama)
        {
            List<MinimarketApp.Model.Entity.Seller> pelanggan = controller.ReadByNama(nama);
            guna2DataGridView1.DataSource = pelanggan;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "" || guna2TextBox4.Text == "" || guna2TextBox5.Text == "")
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
                else
                {
                    var item = new MinimarketApp.Model.Entity.Seller()
                    {
                        KdSeller = Convert.ToInt32(guna2TextBox2.Text),
                        Nama = guna2TextBox1.Text,
                        Pass = guna2TextBox3.Text,
                        Umur = Convert.ToInt32(guna2TextBox4.Text),
                        Nohp = Convert.ToInt32(guna2TextBox5.Text)
                    };
                    var res = controller.Update(item);
                    if (res > 0)
                    {

                        MessageBox.Show("Seller Berhasil Diupdate");
                    }
                    else
                    {
                        MessageBox.Show("Seller Gagal Diupdaten");
                    }
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox2.Text == "")
                {
                    MessageBox.Show("Pilih Pelanggan yang akan didelete");
                }
                else
                {
                    var item = new MinimarketApp.Model.Entity.Seller()
                    {
                        KdSeller = Convert.ToInt32(guna2TextBox2.Text),
                        Nama = guna2TextBox1.Text,
                        Pass = guna2TextBox3.Text,
                        Umur = Convert.ToInt32(guna2TextBox4.Text),
                        Nohp = Convert.ToInt32(guna2TextBox5.Text)
                    };
                    var res = controller.Delete(item);
                    if (res > 0)
                    {

                        MessageBox.Show("Seller Berhasil Dihapus");
                    }
                    else
                    {
                        MessageBox.Show("Seller Gagal Dihapus");
                    }
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new MinimarketApp.Model.Entity.Seller()
                {
                    KdSeller = Convert.ToInt32(guna2TextBox2.Text),
                    Nama = guna2TextBox1.Text,
                    Pass = guna2TextBox3.Text,
                    Umur = Convert.ToInt32(guna2TextBox4.Text),
                    Nohp = Convert.ToInt32(guna2TextBox5.Text)
                };
                var res = controller.Create(item);
                if (res > 0)
                {

                    MessageBox.Show("Seller Berhasil Ditambahkan");
                }
                else
                {
                    MessageBox.Show("Seller Gagal Ditambahkan");
                }
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox2.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            guna2TextBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            guna2TextBox3.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            guna2TextBox4.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            guna2TextBox5.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Main log = new Main();
            log.Show();
            this.Hide();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cariTB.Text == "")
            {
                populate();
            }
            else
            {
                populateNama(cariTB.Text.ToString());
            }
        }
    }
}
