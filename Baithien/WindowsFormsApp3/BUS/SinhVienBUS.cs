using WindowsFormsApp3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.BUS
{
    
    class SinhVienBUS
    {
        
        
        private List<SinhVienDTO> LstSV;
        internal List<SinhVienDTO> lstSV { get => LstSV; set => LstSV= value; }
        public SinhVienBUS()
        {
           
            this.LstSV = new List<SinhVienDTO>();
        }
        public void themSinhVien(SinhVienDTO sv)
        {
            this.LstSV.Add(sv);
        }
        public SinhVienDTO tim(string masv)
        {
            foreach (SinhVienDTO sv in lstSV)
                if (sv.MaSV.Equals(masv))
                    return sv;
            return null;
        }
    
    }
}
