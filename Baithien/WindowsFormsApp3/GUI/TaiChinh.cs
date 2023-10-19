using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.BUS;
using WindowsFormsApp3.DTO;
namespace WindowsFormsApp3.GUI
{
    public partial class TaiChinh : Form
    {
       
        private TaiChinhBUS tcbus;
        TaiChinhBUS tcBUS = new TaiChinhBUS();
        public TaiChinh()
        {
            InitializeComponent();
            tcbus = new TaiChinhBUS();
        }
      
        private TaiChinhDTO taodon()
        {
            return new TaiChinhDTO(txtMAGV.Text,txtTENGV.Text, double.Parse(txtSONL.Text), double.Parse(txtSONN.Text), double.Parse(txtHSL.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaiChinh_Load(object sender, EventArgs e)
        {
           
        }
        public bool Checkcontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMAGV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMAGV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTENGV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTENGV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSONL.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày làm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSONL.Focus();
                return false;
            }
        
            if (string.IsNullOrWhiteSpace(txtHSL.Text))
            {
                MessageBox.Show("Vui lòng nhập hệ số luong.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHSL.Focus();
                return false;
            }

            if (tcbus.timGV(txtMAGV.Text) != null)
            {
                MessageBox.Show("Mã số đã tồn tại.");

                return false;
            }
            return true;
        }
        public bool Checkcontrolsuaa()
        {
            if (string.IsNullOrWhiteSpace(txtMAGV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMAGV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTENGV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTENGV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSONL.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày làm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSONL.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHSL.Text))
            {
                MessageBox.Show("Vui lòng nhập hệ số luong.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHSL.Focus();
                return false;
            }

          
            return true;
        }
        private void btnCAPNHAT_Click(object sender, EventArgs e)
        {
            if (Checkcontrol())
            {


                tcbus.them(taodon());
                dataLAMVIEC.DataSource = null;
                dataLAMVIEC.DataSource = tcbus.bill;
                dataLAMVIEC.Refresh();

            }
        }
        int index;
        private void btnSUA_Click(object sender, EventArgs e)
        {
            if (Checkcontrolsuaa())
            {
                tcbus.bill[index].MaGV = txtMAGV.Text;
                tcbus.bill[index].HoTen = txtTENGV.Text;
                tcbus.bill[index].NgayLam = double.Parse(txtSONL.Text);
                tcbus.bill[index].NgayN = double.Parse(txtSONN.Text);
                tcbus.bill[index].HSL = double.Parse(txtHSL.Text);
                dataLAMVIEC.DataSource = null;
                dataLAMVIEC.DataSource = tcbus.bill;
            }
        }

        private void txtTIMKIEM_TextChanged(object sender, EventArgs e)
        {
            string value = txtTIMKIEM.Text;

            if (!string.IsNullOrWhiteSpace(value))
            {
                dataLAMVIEC.DataSource = null;
                dataLAMVIEC.DataSource = tcbus.bill;
                List<TaiChinhDTO> tmp = new List<TaiChinhDTO>();
                for (int i = 0; i < dataLAMVIEC.Rows.Count; i++)
                    if (dataLAMVIEC.Rows[i].Cells[1].Value.ToString().ToLower().Contains(value.ToLower()))
                        tmp.Add(tcbus.bill[i]);
                if (tmp.Count > 0)
                {
                    dataLAMVIEC.DataSource = null;
                    dataLAMVIEC.DataSource = tmp;
                }
            }
            else
            {
                dataLAMVIEC.DataSource = null;
                dataLAMVIEC.DataSource = tcBUS;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không? ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                tcbus.bill.RemoveAt(index);
                dataLAMVIEC.DataSource = null;
                dataLAMVIEC.DataSource = tcbus.bill;
            }
        }
    }
}
