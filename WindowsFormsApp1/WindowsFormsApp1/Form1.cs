﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-238CB0R\SQLEXPRESS02;Initial Catalog=tour;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("select * from NguoiDung where TaiKhoan=@taiKhoan and MatKhau=@matKhau",con);
            con.Open();
            cmd.Parameters.AddWithValue("taiKhoan", tbName.Text);
            cmd.Parameters.AddWithValue("matKhau", tbPass.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Ban da nhap sai!");
            con.Close();
            if (DialogResult == DialogResult.OK)
            {
                HeThongForm ht = new HeThongForm();
                ht.ShowDialog();
            }

            con.Close();

        }
    }
}
