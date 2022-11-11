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
    public partial class FormThem : Form
    {
        public FormThem()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // load data từ file
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
            // kiểm tra trùng
            for(int i = 0; i < DSSV.Count; i++)
            {
                if (DSSV[i].MSSV == textBoxMSSV.Text)
                {
                    MessageBox.Show("Đã tồn tại sinh viên có MSSV vừa nhập");
                    return;
                }
            }
            // thực hiện lưu data vào file
            SinhVien sv = new SinhVien();
            sv.MSSV = textBoxMSSV.Text;
            sv.HoTen = textBoxHoTen.Text;
            sv.MaLop = textBoxLop.Text;
            sv.DTB = double.Parse(textBoxDTB.Text);
            DSSV.Add(sv);
            List<string> strJoinList = new List<string>();
            for(int i = 0; i < DSSV.Count; i++)
            {
                string temp = DSSV[i].MSSV + "/" + DSSV[i].HoTen + "/" + DSSV[i].MaLop + "/" + DSSV[i].DTB.ToString();
                strJoinList.Add(temp);
            }
            File.WriteAllLines("dataQLSV.txt", strJoinList);

            // thông báo thêm thành công
            MessageBox.Show("Thêm thành công");
        }
    }
}
