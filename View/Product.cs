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
    public partial class Product : Form
    {
        private ProductController controller = new ProductController();
        private SQLiteConnection Con;
        public Product()
        {
            Con = new SQLiteConnection(@"Data Source=D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\Database\DbSupermarket.db;Version=3;");
            InitializeComponent();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            List<MinimarketApp.Model.Entity.Product> produk = controller.ReadAll();
            ProdDGV.DataSource = produk;
        }

        private void populateProduk(string cat)
        {
            List<MinimarketApp.Model.Entity.Product> produk = controller.ReadByCategory(cat);
            ProdDGV.DataSource = produk;
        }

        private void populateNama(string nama)
        {
            List<MinimarketApp.Model.Entity.Product> produk = controller.ReadByNama(nama);
            ProdDGV.DataSource = produk;
        }

        private void fillcombo()
        {
            Con.Open();
            string query = "select nama from Kategori";
            SQLiteCommand cmd = new SQLiteCommand(query, Con);
            SQLiteDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nama", typeof(string));
            dt.Load(rdr);
            comboBoxDown.ValueMember = "nama";
            comboBoxDown.DataSource = dt;
            comboBoxUp.ValueMember = "nama";
            comboBoxUp.DataSource = dt;
            Con.Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            populate();
            fillcombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seller sell = new Seller();
            sell.Show();
            this.Hide();
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxDown.SelectedIndex = comboBoxDown.FindString(ProdDGV.SelectedRows[0].Cells[4].Value.ToString());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new MinimarketApp.Model.Entity.Product()
                {
                    KdProduct = Convert.ToInt32(ProdId.Text),
                    Nama= ProdName.Text,
                    Jumlah= ProdQty.Text,
                    Harga= Convert.ToInt32(ProdPrice.Text),
                    KdCategory= comboBoxDown.SelectedIndex
                };
                var res = controller.Create(item);
                if(res > 0)
                {

                    MessageBox.Show("Product Berhasil Ditambahkan");
                } else
                {
                    MessageBox.Show("Product Gagal Ditambahkan");
                }
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    var item = new MinimarketApp.Model.Entity.Product()
                    {
                        KdProduct = Convert.ToInt32(ProdId.Text),
                        Nama = ProdName.Text,
                        Jumlah = ProdQty.Text,
                        Harga = Convert.ToInt32(ProdPrice.Text),
                        KdCategory = comboBoxDown.SelectedIndex
                    };
                    var res = controller.Delete(item);
                    if (res > 0)
                    {

                        MessageBox.Show("Product Berhasil Dihapus");
                    }
                    else
                    {
                        MessageBox.Show("Product Gagal Dihapus");
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
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    var item = new MinimarketApp.Model.Entity.Product()
                    {
                        KdProduct = Convert.ToInt32(ProdId.Text),
                        Nama = ProdName.Text,
                        Jumlah = ProdQty.Text,
                        Harga = Convert.ToInt32(ProdPrice.Text),
                        KdCategory = comboBoxDown.SelectedIndex
                    };
                    var res = controller.Update(item);
                    if (res > 0)
                    {

                        MessageBox.Show("Product Berhasil Diupdate");
                    }
                    else
                    {
                        MessageBox.Show("Product Gagal Diupdate");
                    }
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (comboBoxUp.SelectedIndex == -1)
            {
                populate();
            }
            else
            {
                populateProduk(comboBoxUp.SelectedIndex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
