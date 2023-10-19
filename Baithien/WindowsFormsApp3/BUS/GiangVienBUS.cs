using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;

namespace WindowsFormsApp3.BUS
{
    class GiangVienBUS
    {
        private List<GiangVienDTO> LstGV;
        internal List<GiangVienDTO> lstGV { get => LstGV; set => LstGV = value; }

        public GiangVienBUS()
        {
            
            this.LstGV = new List<GiangVienDTO>();
        }
        public void ThemGV(GiangVienDTO gv)
        {
            this.LstGV.Add(gv);
        }
        public GiangVienDTO timGV(string magv)
        {
            foreach (GiangVienDTO gv in lstGV)
                if (gv.MaGV.Equals(magv))
                    return gv;
            return null;
        }
    }
}
