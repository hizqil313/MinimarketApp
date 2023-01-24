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
    public partial class Selling : Form
    {
        private SQLiteConnection Con;
        private BillController controller = new BillController();
        public Selling()
        {
            Con = new SQLiteConnection(@"Data Source=D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\Database\DbSupermarket.db;Version=3;");
            InitializeComponent();
        }
        private void populate()
        {
            Con.Open();
            string query = "select nama, harga from Produk";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(query, Con);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populateBill()
        {
            List<MinimarketApp.Model.Entity.Bill> bill = controller.ReadAll();
            BillDGV.DataSource = bill;
        }

        private void populateBillByNama(string nama)
        {
            List<MinimarketApp.Model.Entity.Bill> bill = controller.ReadByNama(nama);
            BillDGV.DataSource = bill;
        }

        private void fillCombo()
        {
            Con.Open();
            string query = "select nama from Kategori";
            SQLiteCommand cmd = new SQLiteCommand(query, Con);
            SQLiteDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nama", typeof(string));
            dt.Load(rdr);
            SelectCategory.ValueMember = "nama";
            SelectCategory.DataSource = dt;
            Con.Close();
        }


        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdNameTB.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PriceTB.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Selling_Load(object sender, EventArgs e)
        {
            fillCombo();
            Seller.Text = Main.Sellername;
            populate();
            populateBill();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateLabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void SelectCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select nama, harga from Produk where kd_kategori='" + SelectCategory.SelectedIndex.ToString() + "'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(query, Con);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Main log = new Main();
            log.Show();
            this.Hide();
        }

        private void AddProdButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillIDTB.Text == "" || ProdNameTB.Text == "" || QtyTB.Text == "")
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
                else
                {
                    int total = Convert.ToInt32(PriceTB.Text) * Convert.ToInt32(QtyTB.Text);
                    var item = new MinimarketApp.Model.Entity.Bill()
                    {
                        KdBill = Convert.ToInt32(BillIDTB.Text),
                        NamaBrg = ProdNameTB.Text,
                        HargaBrg = Convert.ToInt32(PriceTB.Text),
                        JumlahBrg = Convert.ToInt32(QtyTB.Text),
                        Total = total
                    };
                    int res = controller.Create(item);    
                    if (res > 0)
                    {
                        MessageBox.Show("Bill berhasil ditambah");
                    }
                    else
                    {
                        MessageBox.Show("Bill gagal ditambahkan");
                    }
                    populateBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillIDTB.Text == "" || ProdNameTB.Text == "" || QtyTB.Text == "")
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
                else
                {
                    int total = Convert.ToInt32(PriceTB.Text) * Convert.ToInt32(QtyTB.Text);
                    var item = new MinimarketApp.Model.Entity.Bill()
                    {
                        KdBill = Convert.ToInt32(BillIDTB.Text),
                        NamaBrg = ProdNameTB.Text,
                        HargaBrg = Convert.ToInt32(PriceTB.Text),
                        JumlahBrg = Convert.ToInt32(QtyTB.Text),
                        Total = total
                    };
                    int res = controller.Update(item);
                    if (res > 0)
                    {
                        MessageBox.Show("Bill berhasil diupdate");
                    }
                    else
                    {
                        MessageBox.Show("Bill gagal diupdate");
                    }
                    populateBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillIDTB.Text == "")
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
                else
                {
                    int total = Convert.ToInt32(PriceTB.Text) * Convert.ToInt32(QtyTB.Text);
                    var item = new MinimarketApp.Model.Entity.Bill()
                    {
                        KdBill = Convert.ToInt32(BillIDTB.Text),
                        NamaBrg = ProdNameTB.Text,
                        HargaBrg = Convert.ToInt32(PriceTB.Text),
                        JumlahBrg = Convert.ToInt32(QtyTB.Text),
                    };
                    int res = controller.Delete(item);
                    if (res > 0)
                    {
                        MessageBox.Show("Bill berhasil dihapus");
                    }
                    else
                    {
                        MessageBox.Show("Bill gagal dihapus");
                    }
                    populateBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BillIDTB.Text = BillDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTB.Text = BillDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTB.Text = BillDGV.SelectedRows[0].Cells[3].Value.ToString();
            QtyTB.Text = BillDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cariTB.Text == "")
            {
                populate();
            }
            else
            {
                populateBillByNama(cariTB.Text.ToString());
            }
        }
    }
}
