using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Learn_ModernUI_Winform
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //customizeMenuDisplay();
            object o = new object();
            EventArgs e = new EventArgs();
            btnBackMain_Click(o, e);
        }
        private void customizeMenuDisplay()
        {
            panelSubMenuTimKiem.Visible = false;
            panelSubMenuXoa.Visible = false;
        }
        private void hideAllSubmenu()
        {
            panelSubMenuTimKiem.Visible = false;
            panelSubMenuXoa.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == true)
            {
                subMenu.Visible = false;
            }
            else
            {
                subMenu.Visible = true;
            }
        }
        private void setDefaultButtonColorExceptMain(Button btn)
        {
            btnTimSV.BackColor = Color.FromArgb(63, 146, 207);
            btnThemSV.BackColor = Color.FromArgb(63, 146, 207);
            btnXoaSV.BackColor = Color.FromArgb(63, 146, 207);
            btnSuaSV.BackColor = Color.FromArgb(63, 146, 207);
            btnBackMain.BackColor = Color.FromArgb(63, 146, 207);
            btn.BackColor = Color.FromArgb(44, 125, 192);
        }
        private void setDefaultButtonColorExceptSub(Button btn)
        {
            btnTimTheoMSSV.BackColor = Color.FromArgb(121, 175, 217);
            btnTimTheoTen.BackColor = Color.FromArgb(121, 175, 217);
            btnTimTheoDTB.BackColor = Color.FromArgb(121, 175, 217);
            btnXoaTheoMSSV.BackColor = Color.FromArgb(121, 175, 217);
            btnXoaTheoTen.BackColor = Color.FromArgb(121, 175, 217);
            btnXoaTheoDTB.BackColor = Color.FromArgb(121, 175, 217);
            btn.BackColor = Color.FromArgb(84, 145, 194);
        }

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuTimKiem);
            setDefaultButtonColorExceptMain(btnTimSV);
            Button btn = new Button();
            setDefaultButtonColorExceptSub(btn);
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuXoa);
            setDefaultButtonColorExceptMain(btnXoaSV);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptMain(btnThemSV);
            setDefaultButtonColorExceptSub(new Button());
            loadForm(new FormThem());
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptMain(btnSuaSV);
            setDefaultButtonColorExceptSub(new Button());
            loadForm(new FormSua());
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptSub(btnTimTheoTen);
            FormTimTheoTen f = new FormTimTheoTen();
            loadForm(f);
            
            
        }

        private void btnTimTheoMSSV_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptSub(btnTimTheoMSSV);
            loadForm(new FormTimTheoMSSV());
        }
        private void btnTimTheoDTB_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptSub(btnTimTheoDTB);
            loadForm(new FormTimTheoDTB());
        }

        private void btnXoaTheoTen_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptSub(btnXoaTheoTen);
            loadForm(new FormXoaTheoTen());
        }

        private void btnXoaTheoMSSV_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptSub(btnXoaTheoMSSV);
            loadForm(new FormXoaTheoMSSV());
        }

        private void btnXoaTheoDTB_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptSub(btnXoaTheoDTB);
            loadForm(new FormXoaTheoDTB());
        }

        private void loadForm(object Form)
        {
            if (this.panelChildForm.Controls.Count > 0)
            {
                this.panelChildForm.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(f);
            this.panelChildForm.Tag = f;
            f.Show();
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            setDefaultButtonColorExceptMain(btnBackMain);
            setDefaultButtonColorExceptSub(new Button());
            loadForm(new FormBackToMain());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
