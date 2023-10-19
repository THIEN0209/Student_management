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
using WindowsFormsApp3.GUI;
namespace WindowsFormsApp3.GUI
{
    public partial class NhaTruong : Form
    {
        
        List<string> listLOPCV = new List<string>() { "D20_TH01", "D20_TH02", "QT_01","QT_02" };
        private GiangVienBUS gvbus;
        GiangVienBUS gvBUS = new GiangVienBUS();
        public NhaTruong()
        {
            InitializeComponent();
            gvbus = new GiangVienBUS();
        }
        private GiangVienDTO taogv()
        {
            return new GiangVienDTO(txtMAGV.Text,txtHOTENGV.Text,dateNSGV.Value,txtSDT.Text,cboLOPCV.Text);
        }
        private void btnOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhaTruong_Load(object sender, EventArgs e)
        {
            
            cboLOPCV.DataSource = listLOPCV;
        }
        public bool Checkcontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMAGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMAGV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHOTENGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHOTENGV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboLOPCV.Text))
            {
                MessageBox.Show("Bạn chưa nhập lớp cố vấn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLOPCV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
           
            if (gvbus.timGV(txtMAGV.Text) != null)
            {
                MessageBox.Show("Mã số đã tồn tại.");
                txtMAGV.Focus();
                return false;
            }
            return true;
        }
        public bool Checkcontrolsua()
        {
            if (string.IsNullOrWhiteSpace(txtMAGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMAGV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHOTENGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHOTENGV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboLOPCV.Text))
            {
                MessageBox.Show("Bạn chưa nhập lớp cố vấn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLOPCV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            return true;
           
        }

        private void btnTHEMGV_Click(object sender, EventArgs e)
        {
            if (Checkcontrol())
            {


                gvbus.ThemGV(taogv());
                dataQUANLYGV.DataSource = null;
                dataQUANLYGV.DataSource = gvbus.lstGV;
                dataQUANLYGV.Refresh();

            }
        }
        
        private void btnXOAGV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không? ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                gvbus.lstGV.RemoveAt(index);
                dataQUANLYGV.DataSource = null;
                dataQUANLYGV.DataSource = gvbus.lstGV;
            }
        }
        int index;
        private void btnSUAGV_Click(object sender, EventArgs e)
        {

            if (Checkcontrolsua())
            {
                gvbus.lstGV[index].MaGV = txtMAGV.Text;
                gvbus.lstGV[index].TenGV = txtHOTENGV.Text;
                gvbus.lstGV[index].LopCV = cboLOPCV.Text;
                gvbus.lstGV[index].SDT = txtSDT.Text;
                gvbus.lstGV[index].NgaySinh = dateNSGV.Value;
                dataQUANLYGV.DataSource = null;
                dataQUANLYGV.DataSource = gvbus.lstGV;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string value = textBox5.Text;

            if (!string.IsNullOrWhiteSpace(value))
            {
                dataQUANLYGV.DataSource = null;
                dataQUANLYGV.DataSource = gvbus.lstGV;
                List<GiangVienDTO> tmp = new List<GiangVienDTO>();
                for (int i = 0; i < dataQUANLYGV.Rows.Count; i++)
                    if (dataQUANLYGV.Rows[i].Cells[1].Value.ToString().ToLower().Contains(value.ToLower()))
                        tmp.Add(gvbus.lstGV[i]);
                if (tmp.Count > 0)
                {
                    dataQUANLYGV.DataSource = null;
                    dataQUANLYGV.DataSource = tmp;
                }
            }
            else
            {
                dataQUANLYGV.DataSource = null;
                dataQUANLYGV.DataSource = gvBUS;
            }
        }
    }
}
