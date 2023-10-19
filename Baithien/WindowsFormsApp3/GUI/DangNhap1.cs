using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.GUI;
namespace WindowsFormsApp3
{
    public partial class DangNhap1 : Form
    {
        public DangNhap1()
        {
            InitializeComponent();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDANGNHAP_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();

        }

        private void DangNhap1_Load(object sender, EventArgs e)
        {

        }
    }
}
