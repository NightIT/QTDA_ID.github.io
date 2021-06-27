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
    public partial class LopTC : Form
    {
        public LopTC()
        {
            InitializeComponent();
        }
        string ketnoi = @"Data Source=DESKTOP-238CB0R\SQLEXPRESS02;Initial Catalog=Tour;Integrated Security=True;";
        public void HienThi()
        {
            SqlConnection con = new SqlConnection(ketnoi);
            SqlCommand cmd = new SqlCommand("select * from KhachHang order by MaKH asc",con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            adapter.Fill(set, "S");
            dataGridView1.DataSource = set.Tables["S"];

        }

        private void LopTC_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(ketnoi);
                SqlCommand cmd = new SqlCommand("delete from KhachHang where MaKH='"+textBox1.Text+"'",con);
                con.Open();
                cmd.ExecuteNonQuery();
                HienThi();
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ketnoi);
            try 
            {
                con.Open();
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox7.Text != "" && textBox6.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into KhachHang values('"+textBox1.Text+ "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox7.Text + "', '" + textBox6.Text + "')", con);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Them thanh cong!");
                        HienThi();
                    }
                    else
                        MessageBox.Show("Them that bai!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi!" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ketnoi);
            try
            {
                con.Open();
                    SqlCommand cmd = new SqlCommand("update KhachHang set MaTour ='" + textBox2.Text + "',TenKH ='" + textBox3.Text + "',SDT ='" + textBox4.Text + "',HoChieu ='" + textBox7.Text + "',MaNV ='" + textBox6.Text + "' where MaKH ='" + textBox1.Text + "'", con);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sua thanh cong!");
                        HienThi();
                    }
                    else
                        MessageBox.Show("Sua that bai!");
                    con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi!" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ketnoi);
            SqlCommand cmd = new SqlCommand("select * from KhachHang where MaKH=@makh",con);
            con.Open();
            cmd.Parameters.AddWithValue("makh",textBox5.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
        }
          
        }
}

