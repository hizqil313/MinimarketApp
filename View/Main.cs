﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SimpleSupermarketApp
{
    public partial class Main : Form
    {
        private SQLiteConnection Con;
        public Main()
        {
            Con = new SQLiteConnection(@"Data Source=D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\Database\DbSupermarket.db;Version=3;");
            InitializeComponent();
        }
        public static string Sellername = "";

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Role.SelectedIndex <= -1 || Role.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Select a role");
            }
            else if (usernameTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Enter The User Name and Password");
            }
            else
            {
                if (Role.SelectedItem.ToString() == "ADMIN")
                {
                    if (usernameTB.Text == "Admin" && passwordTB.Text == "Admin")
                    {
                        Product prod = new Product();
                        prod.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If you are the admin, enter the correct username and password!");
                    }
                }
                else if (Role.SelectedItem.ToString() == "SELLER")
                {
                    Con.Open();
                    SQLiteDataAdapter sda = new SQLiteDataAdapter("Select count(8) from Pelanggan where nama='" + usernameTB.Text + "' and password='" + passwordTB.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Sellername = usernameTB.Text;
                        Selling sell = new Selling();
                        sell.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
        }


    }
}
