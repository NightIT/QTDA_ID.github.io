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
    public partial class HeThongForm : Form
    {
        public HeThongForm()
        {
            InitializeComponent();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVienForm sv = new SinhVienForm();
            sv.ShowDialog();
        }

        private void lopTCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopTC lopTC = new LopTC();
            lopTC.ShowDialog();
            
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HeThongForm_Load(object sender, EventArgs e)
        {
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            LogInForm loginForm = new LogInForm();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
