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
    public partial class FormXoaTheoMSSV : Form
    {
        public FormXoaTheoMSSV()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
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
            //tìm sinh viên
            for(int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].MSSV == textBoxFind.Text)
                {
                    setSinhVienHienTai(DSSV[i]);
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy sinh viên có MSSV vừa nhập");
        }
        private void btnXoa_Click(object sender, EventArgs e)
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
            //Xoa
            int index = 0;
            for (int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].Equals(getSinhVienHienTai()))
                {
                    index = i;
                    break;
                }
            }
            DSSV.RemoveAt(index);
            MessageBox.Show("Xóa thành công");
            //cập nhật data vào file
            List<string> strJoinList = new List<string>();
            for (int i = 0; i < DSSV.Count; i++)
            {
                string temp = DSSV[i].MSSV + "/" + DSSV[i].HoTen + "/" + DSSV[i].MaLop + "/" + DSSV[i].DTB.ToString();
                strJoinList.Add(temp);
            }
            File.WriteAllLines("dataQLSV.txt", strJoinList);
        }

    }
}
