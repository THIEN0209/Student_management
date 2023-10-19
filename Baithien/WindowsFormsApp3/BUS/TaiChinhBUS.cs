using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;

namespace WindowsFormsApp3.BUS
{
   class TaiChinhBUS
    {
        private List<TaiChinhDTO> Bill;
        internal List<TaiChinhDTO> bill { get => Bill; set => Bill = value; }

        public TaiChinhBUS()
        {
            this.Bill = new List<TaiChinhDTO>();
        }
        public void them(TaiChinhDTO bll)
        {
            Bill.Add(bll);
        }
      
        public TaiChinhDTO timGV(string mgv)
        {
            foreach (TaiChinhDTO bll in bill)
                if (bll.MaGV.Equals(mgv))
                    return bll;
            return null;
        }
    }
}
