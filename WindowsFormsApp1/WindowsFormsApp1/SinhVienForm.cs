using System;
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
    public partial class SinhVienForm : Form
    {
        public SinhVienForm()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-238CB0R\SQLEXPRESS02;Initial Catalog=Tour;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien ORDER BY TenNV ASC", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet, "SV");
            dataGridView1.DataSource = dataSet.Tables["SV"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-238CB0R\SQLEXPRESS02;Initial Catalog=sinhvien;Integrated Security=True;");
            //SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien ORDER BY TenSV ASC", conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet dataSet = new DataSet();
            //da.Fill(dataSet, "SV");
            //dataGridView1.DataSource = dataSet.Tables["SV"];

        }
    }
}
