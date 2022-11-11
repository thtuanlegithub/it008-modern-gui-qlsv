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
    public partial class FormTimTheoDTB : Form
    {
        public FormTimTheoDTB()
        {
            InitializeComponent();
            btnNext.Visible = false;
        }
        static private List<SinhVien> DSSV_kq = new List<SinhVien>();
        static int currKQ = 0;
        private void btnTimTheoDTB_Click(object sender, EventArgs e)
        {
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
            DSSV_kq = new List<SinhVien>();
            // Tạo list kết quả
            bool exist = false;
            for (int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].DTB == double.Parse(this.getTextFind()))
                {
                    exist = true;
                    DSSV_kq.Add(DSSV[i]);
                }
            }
            if (exist)
            {
                setSinhVienHienTai(DSSV_kq[0]);
                if (DSSV_kq.Count > 1)
                {
                    btnNext.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại sinh viên có tên cần tìm!");
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currKQ < DSSV_kq.Count)
            {
                setSinhVienHienTai(DSSV_kq[++currKQ]);
                if (currKQ == DSSV_kq.Count - 1)
                {
                    btnNext.Visible = false;
                }
            }
        }
    }
}
