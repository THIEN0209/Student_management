using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.BUS;
namespace WindowsFormsApp3.DTO
{
    internal class GiangVienDTO
    {
       



        public string MaGV { set; get; }
        public string TenGV { set; get; }
        public string LopCV { set; get; }
        public DateTime NgaySinh { set; get; }
        public string SDT { set; get; }
      
        public GiangVienDTO()
        {
            MaGV = "";
            TenGV = "";
            LopCV = "";
            NgaySinh = DateTime.Today ;
            SDT = "";
        }
        public GiangVienDTO(string mgv, string tgv,DateTime ngaysinh,string sdt, string lop)
        {
            MaGV = mgv;
            TenGV = tgv;
            NgaySinh = ngaysinh;
            LopCV = lop;
            SDT = sdt;
           
        }
    }
}
