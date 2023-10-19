using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DTO
{
   
    internal class TaiChinhDTO
    {
    

        public string MaGV { set; get; }
        public string HoTen { set; get; }
        public double NgayLam { set; get; }
        public double NgayN { set; get; }
        public double HSL { set; get; }
        public double ThanhTien { get { return (NgayLam - NgayN) * HSL; } }

        public TaiChinhDTO()
        {
            MaGV = " ";
            HoTen = " ";
            NgayLam= 0;
            NgayN = 0;
            HSL= 0;

            
        }
        public TaiChinhDTO(string mgv,string ht,double ngl,double ngn,double hsl){
            MaGV = mgv;
            HoTen = ht;
            NgayLam = ngl;
            NgayN = ngn;
            HSL = hsl;
           
}
    }
}
