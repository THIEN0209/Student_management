using WindowsFormsApp3.BUS;
using WindowsFormsApp3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    public partial class SinhVien : Form
    {
        private SinhVienBUS svbus;

        SinhVienBUS svBUS = new SinhVienBUS();
        List<string> listgioitinh = new List<string>() { "Khác", "Nữ", "Nam" };
        public SinhVien()
        {
            InitializeComponent();
            svbus = new SinhVienBUS();
        }
        


        private SinhVienDTO taosv()
        {
            return new SinhVienDTO(txtMSSV.Text, txtHOTEN.Text, dateNGAYSINH.Value, txtNGANH.Text, txtLOP.Text,cbogioitinh.Text);
        }
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            txtHOTEN.Text = "";
            txtLOP.Text = "";
            txtMSSV.Text = "";
            txtNGANH.Text = "";
            
        }
        public bool CheckcontrolSUA()
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHOTEN.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHOTEN.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNGANH.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngành sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNGANH.Focus();
                return false;
            }
          
            if (string.IsNullOrWhiteSpace(txtLOP.Text))
            {
                MessageBox.Show("Bạn chưa nhập lớp sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLOP.Focus();
                return false;
            }
          
            return true;
        }
        public bool Checkcontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHOTEN.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHOTEN.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNGANH.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngành sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNGANH.Focus();
                return false;
            }
          
            if (string.IsNullOrWhiteSpace(txtLOP.Text))
            {
                MessageBox.Show("Bạn chưa nhập lớp sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLOP.Focus();
                return false;
            }
            if (svbus.tim(txtMSSV.Text) != null)
            {
                MessageBox.Show("Mã số đã tồn tại.");
                txtMSSV.Focus();
                return false;
            }
            return true;
        }
        private void btnTHEM_Click(object sender, EventArgs e)
        {
            if (Checkcontrol())
            {

              
                svbus.themSinhVien(taosv());
                dataDANHSACHSV.DataSource = null;
                dataDANHSACHSV.DataSource = svbus.lstSV;
                dataDANHSACHSV.Refresh();

            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbogioitinh.DataSource = listgioitinh;
            
        }

        private void txtNGAYSINH_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtNGAYSINH_Leave(object sender, EventArgs e)
        {
            
        }

        private void dataDANHSACHSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ColHOTEN.ReadOnly = true;
            ColGIOITINH.ReadOnly = true;
            ColLOP.ReadOnly = true;
            ColMSSV.ReadOnly = true;
            ColNGANH.ReadOnly = true;
            ColNGAYSINH.ReadOnly = true;
            
           
        }
        int index;
        private void dataDANHSACHSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<SinhVienDTO> tmp = new List<SinhVienDTO>();
               index = e.RowIndex;
            if (index >= 0)
            {
                txtMSSV.Text = svbus.lstSV[index].MaSV;
                txtHOTEN.Text = svbus.lstSV[index].TenSV;
                dateNGAYSINH.Value = svbus.lstSV[index].NgaySinh;
                txtNGANH.Text = svbus.lstSV[index].Nganh;
                txtLOP.Text = svbus.lstSV[index].Lop;
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {

                if (CheckcontrolSUA())
                {
                    svbus.lstSV[index].MaSV = txtMSSV.Text;
                    svbus.lstSV[index].TenSV = txtHOTEN.Text;
                    svbus.lstSV[index].Nganh = txtNGANH.Text;
                    svbus.lstSV[index].Lop = txtLOP.Text;
                svbus.lstSV[index].NgaySinh = dateNGAYSINH.Value;
                    dataDANHSACHSV.DataSource = null;
                    dataDANHSACHSV.DataSource = svbus.lstSV;
                }
            
            

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không? ","Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                svbus.lstSV.RemoveAt(index);
                dataDANHSACHSV.DataSource = null;
                dataDANHSACHSV.DataSource = svbus.lstSV;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(value))
            {
                dataDANHSACHSV.DataSource = null;
                dataDANHSACHSV.DataSource = svbus.lstSV;
                List<SinhVienDTO> tmp = new List<SinhVienDTO>();
                for (int i = 0; i < dataDANHSACHSV.Rows.Count; i++)
                    if (dataDANHSACHSV.Rows[i].Cells[1].Value.ToString().ToLower().Contains(value.ToLower()))
                        tmp.Add(svbus.lstSV[i]);
                if (tmp.Count > 0)
                {
                    dataDANHSACHSV.DataSource = null;
                    dataDANHSACHSV.DataSource = tmp;
                }
            }
            else
            {
                dataDANHSACHSV.DataSource = null;
                dataDANHSACHSV.DataSource = svBUS;
            }
        }

        private void btnTIMKIEM_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void cbogioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
