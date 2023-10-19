using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentchildform;
        private void Openchildform(Form childform)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelbody.Controls.Add(childform);
            panelbody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void btnOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGIANVIEN1_Click(object sender, EventArgs e)
        {
            Openchildform(new SinhVien());
            label1.Text = "QUẢN LÝ SINH VIÊN";

        }

        private void btnGIANVIEN2_Click(object sender, EventArgs e)
        {
            Openchildform(new TaiChinh());
            label1.Text = "QUẢN LÝ GIẢNG VIÊN";
        }

        private void btnTRUONG_Click(object sender, EventArgs e)
        {
            Openchildform(new NhaTruong());
            label1.Text = "QUẢN LÝ NHÂN SỰ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            label1.Text = "HOME";
        }
    }
}
