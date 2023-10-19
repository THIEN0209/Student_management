using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DTO
{
    class SinhVienDTO
    { 
            public string MaSV { set; get; }
        public string TenSV { set; get; }
        public DateTime NgaySinh { set; get; }
        public string Nganh { set; get; }
        public string Lop { set; get; }
        
        public string GioiTinh { set; get; }
        public SinhVienDTO()
        {
            MaSV = " ";
            TenSV = " ";
            NgaySinh = DateTime.Today ;
            Nganh = " ";
            Lop = "";
            
            GioiTinh = " ";
        }
        public SinhVienDTO(string msv, string tsv, DateTime ngaysinh, string nganh, string lop,string gt)
        {
            MaSV = msv;
            TenSV = tsv;
            NgaySinh = ngaysinh;
            Nganh = nganh;
            Lop = lop;
            
            GioiTinh = gt;
        }

    }
}

