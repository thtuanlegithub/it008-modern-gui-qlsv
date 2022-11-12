namespace Learn_ModernUI_Winform
{
    partial class FormSua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSua));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.labelDTB = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.textBoxDTB = new System.Windows.Forms.TextBox();
            this.textBoxLop = new System.Windows.Forms.TextBox();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxMSSV = new System.Windows.Forms.TextBox();
            this.labelMSSV = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelThongTinSinhVien = new System.Windows.Forms.Label();
            this.pictureBoxAnhSV = new System.Windows.Forms.PictureBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.labelNhapTen = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.panelTitleChildFormTimTheoTen = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnhSV)).BeginInit();
            this.panelTitleChildFormTimTheoTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.labelDTB);
            this.panel1.Controls.Add(this.labelLop);
            this.panel1.Controls.Add(this.textBoxDTB);
            this.panel1.Controls.Add(this.textBoxLop);
            this.panel1.Controls.Add(this.textBoxHoTen);
            this.panel1.Controls.Add(this.textBoxMSSV);
            this.panel1.Controls.Add(this.labelMSSV);
            this.panel1.Controls.Add(this.labelHoTen);
            this.panel1.Controls.Add(this.labelThongTinSinhVien);
            this.panel1.Controls.Add(this.pictureBoxAnhSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 404);
            this.panel1.TabIndex = 7;
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.Location = new System.Drawing.Point(288, 314);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 36);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labelDTB
            // 
            this.labelDTB.AutoSize = true;
            this.labelDTB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDTB.ForeColor = System.Drawing.Color.White;
            this.labelDTB.Location = new System.Drawing.Point(232, 246);
            this.labelDTB.Name = "labelDTB";
            this.labelDTB.Size = new System.Drawing.Size(158, 25);
            this.labelDTB.TabIndex = 2;
            this.labelDTB.Text = "Điểm trung bình:";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLop.ForeColor = System.Drawing.Color.White;
            this.labelLop.Location = new System.Drawing.Point(232, 194);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(49, 25);
            this.labelLop.TabIndex = 2;
            this.labelLop.Text = "Lớp:";
            // 
            // textBoxDTB
            // 
            this.textBoxDTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(147)))), ((int)(((byte)(190)))));
            this.textBoxDTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDTB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDTB.Location = new System.Drawing.Point(405, 238);
            this.textBoxDTB.Multiline = true;
            this.textBoxDTB.Name = "textBoxDTB";
            this.textBoxDTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxDTB.Size = new System.Drawing.Size(175, 33);
            this.textBoxDTB.TabIndex = 5;
            // 
            // textBoxLop
            // 
            this.textBoxLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(147)))), ((int)(((byte)(190)))));
            this.textBoxLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLop.Location = new System.Drawing.Point(313, 192);
            this.textBoxLop.Multiline = true;
            this.textBoxLop.Name = "textBoxLop";
            this.textBoxLop.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxLop.Size = new System.Drawing.Size(178, 33);
            this.textBoxLop.TabIndex = 4;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(147)))), ((int)(((byte)(190)))));
            this.textBoxHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.Location = new System.Drawing.Point(329, 83);
            this.textBoxHoTen.Multiline = true;
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxHoTen.Size = new System.Drawing.Size(204, 33);
            this.textBoxHoTen.TabIndex = 3;
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMSSV.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMSSV.Location = new System.Drawing.Point(405, 134);
            this.textBoxMSSV.Multiline = true;
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.ReadOnly = true;
            this.textBoxMSSV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxMSSV.Size = new System.Drawing.Size(208, 33);
            this.textBoxMSSV.TabIndex = 7;
            // 
            // labelMSSV
            // 
            this.labelMSSV.AutoSize = true;
            this.labelMSSV.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMSSV.ForeColor = System.Drawing.Color.White;
            this.labelMSSV.Location = new System.Drawing.Point(232, 142);
            this.labelMSSV.Name = "labelMSSV";
            this.labelMSSV.Size = new System.Drawing.Size(150, 25);
            this.labelMSSV.TabIndex = 2;
            this.labelMSSV.Text = "Mã số sinh viên:";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.ForeColor = System.Drawing.Color.White;
            this.labelHoTen.Location = new System.Drawing.Point(232, 85);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(75, 25);
            this.labelHoTen.TabIndex = 2;
            this.labelHoTen.Text = "Họ tên:";
            // 
            // labelThongTinSinhVien
            // 
            this.labelThongTinSinhVien.AutoSize = true;
            this.labelThongTinSinhVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongTinSinhVien.ForeColor = System.Drawing.Color.White;
            this.labelThongTinSinhVien.Location = new System.Drawing.Point(220, 20);
            this.labelThongTinSinhVien.Name = "labelThongTinSinhVien";
            this.labelThongTinSinhVien.Size = new System.Drawing.Size(234, 32);
            this.labelThongTinSinhVien.TabIndex = 1;
            this.labelThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // pictureBoxAnhSV
            // 
            this.pictureBoxAnhSV.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAnhSV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnhSV.Image")));
            this.pictureBoxAnhSV.Location = new System.Drawing.Point(27, 48);
            this.pictureBoxAnhSV.Name = "pictureBoxAnhSV";
            this.pictureBoxAnhSV.Size = new System.Drawing.Size(187, 223);
            this.pictureBoxAnhSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnhSV.TabIndex = 0;
            this.pictureBoxAnhSV.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.Location = new System.Drawing.Point(524, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 29);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnTimTheoMSSV_Click);
            // 
            // labelNhapTen
            // 
            this.labelNhapTen.AutoSize = true;
            this.labelNhapTen.BackColor = System.Drawing.Color.Transparent;
            this.labelNhapTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhapTen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNhapTen.Location = new System.Drawing.Point(67, 25);
            this.labelNhapTen.Name = "labelNhapTen";
            this.labelNhapTen.Size = new System.Drawing.Size(123, 25);
            this.labelNhapTen.TabIndex = 0;
            this.labelNhapTen.Text = "Nhập MSSV:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFind.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.Location = new System.Drawing.Point(208, 21);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(294, 33);
            this.textBoxFind.TabIndex = 1;
            // 
            // panelTitleChildFormTimTheoTen
            // 
            this.panelTitleChildFormTimTheoTen.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitleChildFormTimTheoTen.Controls.Add(this.btnFind);
            this.panelTitleChildFormTimTheoTen.Controls.Add(this.labelNhapTen);
            this.panelTitleChildFormTimTheoTen.Controls.Add(this.textBoxFind);
            this.panelTitleChildFormTimTheoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleChildFormTimTheoTen.Location = new System.Drawing.Point(0, 0);
            this.panelTitleChildFormTimTheoTen.Name = "panelTitleChildFormTimTheoTen";
            this.panelTitleChildFormTimTheoTen.Size = new System.Drawing.Size(711, 72);
            this.panelTitleChildFormTimTheoTen.TabIndex = 8;
            // 
            // FormSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleChildFormTimTheoTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSua";
            this.Text = "FormSua";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnhSV)).EndInit();
            this.panelTitleChildFormTimTheoTen.ResumeLayout(false);
            this.panelTitleChildFormTimTheoTen.PerformLayout();
            this.ResumeLayout(false);

        }
        public string getTextFind()
        {
            return textBoxFind.Text;
        }

        public void setTextMSSV(string MSSV)
        {
            textBoxMSSV.Text = MSSV;
        }
        public void setTextMaLop(string MaLop)
        {
            textBoxLop.Text = MaLop;
        }
        public void setTextHoTen(string HoTen)
        {
            textBoxHoTen.Text = HoTen;
        }
        public void setTextDTB(double DTB)
        {
            textBoxDTB.Text = DTB.ToString();
        }
        public SinhVien getSinhVienHienTai()
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = this.textBoxMSSV.Text;
            sv.HoTen = this.textBoxHoTen.Text;
            sv.MaLop = this.textBoxLop.Text;
            sv.DTB = double.Parse(textBoxDTB.Text);
            return sv;
        }
        public void setSinhVienHienTai(SinhVien sv)
        {
            textBoxHoTen.Text = sv.HoTen;
            textBoxMSSV.Text = sv.MSSV;
            textBoxDTB.Text = sv.DTB.ToString();
            textBoxLop.Text = sv.MaLop;
        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDTB;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.TextBox textBoxDTB;
        private System.Windows.Forms.TextBox textBoxLop;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxMSSV;
        private System.Windows.Forms.Label labelMSSV;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelThongTinSinhVien;
        private System.Windows.Forms.PictureBox pictureBoxAnhSV;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label labelNhapTen;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Panel panelTitleChildFormTimTheoTen;
        private System.Windows.Forms.Button btnSua;
    }
}