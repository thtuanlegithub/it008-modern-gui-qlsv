using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ModernUI_Winform
{
    public class SinhVien
    {
        public string HoTen;
        public string MSSV;
        public string MaLop;
        public double DTB;
        public bool  Equals(SinhVien other)
        {
            return HoTen == other.HoTen && MSSV == other.MSSV && MaLop == other.MaLop && DTB == other.DTB;
        }
    }
}
