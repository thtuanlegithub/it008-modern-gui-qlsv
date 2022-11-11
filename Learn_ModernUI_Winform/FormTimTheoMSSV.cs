using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Learn_ModernUI_Winform
{
    public partial class FormTimTheoMSSV : Form
    {
        public FormTimTheoMSSV()
        {
            InitializeComponent();
        }

        private void btnTimTheoMSSV_Click(object sender, EventArgs e)
        {
            //load data từ file
            string[] str_data = File.ReadAllLines("dataQLSV.txt");
            List<SinhVien> DSSV = new List<SinhVien>();
            for (int i = 0; i < str_data.Length; i++)
            {
                SinhVien _sv = new SinhVien();
                string[] str_split = str_data[i].Split('/');
                _sv.MSSV = str_split[0];
                _sv.HoTen = str_split[1];
                _sv.MaLop = str_split[2];
                _sv.DTB = double.Parse(str_split[3]);
                DSSV.Add(_sv);
            }
            // hiển thị sinh viên
            bool exist = false;
            SinhVien sv = new SinhVien();
            for (int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].MSSV == this.getTextFind())
                {
                    exist = true;
                    sv = DSSV[i];
                }
            }
            if (exist)
            {
                this.setTextHoTen(sv.HoTen);
                this.setTextMSSV(sv.MSSV);
                this.setTextDTB(sv.DTB);
                this.setTextMaLop(sv.MaLop);
            }
            else
            {
                MessageBox.Show("Không tồn tại sinh viên có MSSV cần tìm!");
            }
        }
    }
}
