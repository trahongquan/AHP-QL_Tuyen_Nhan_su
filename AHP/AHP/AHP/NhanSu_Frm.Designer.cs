namespace AHP
{
    partial class NhanSu_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanSu_Frm));
            dtgv_diem = new DataGridView();
            txt_kinh_nghiem = new TextBox();
            lab_kinh_nghiem = new Label();
            txt_chuyen_mon = new TextBox();
            lab_ma_so = new Label();
            txt_do_tuoi = new TextBox();
            label1 = new Label();
            txt_ky_nang_mem = new TextBox();
            label2 = new Label();
            txt_ma_so = new TextBox();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            doneToolStripMenuItem = new ToolStripMenuItem();
            tinhToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgv_diem).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv_diem
            // 
            dtgv_diem.AllowUserToAddRows = false;
            dtgv_diem.AllowUserToDeleteRows = false;
            dtgv_diem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_diem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_diem.ImeMode = ImeMode.Disable;
            dtgv_diem.Location = new Point(10, 132);
            dtgv_diem.Margin = new Padding(3, 2, 3, 2);
            dtgv_diem.MultiSelect = false;
            dtgv_diem.Name = "dtgv_diem";
            dtgv_diem.RowHeadersWidth = 51;
            dtgv_diem.RowTemplate.Height = 29;
            dtgv_diem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_diem.Size = new Size(679, 165);
            dtgv_diem.TabIndex = 11;
            dtgv_diem.TabStop = false;
            // 
            // txt_kinh_nghiem
            // 
            txt_kinh_nghiem.ForeColor = Color.Red;
            txt_kinh_nghiem.Location = new Point(465, 62);
            txt_kinh_nghiem.Margin = new Padding(3, 2, 3, 2);
            txt_kinh_nghiem.Name = "txt_kinh_nghiem";
            txt_kinh_nghiem.ReadOnly = true;
            txt_kinh_nghiem.Size = new Size(220, 23);
            txt_kinh_nghiem.TabIndex = 15;
            // 
            // lab_kinh_nghiem
            // 
            lab_kinh_nghiem.AutoSize = true;
            lab_kinh_nghiem.Location = new Point(376, 64);
            lab_kinh_nghiem.Name = "lab_kinh_nghiem";
            lab_kinh_nghiem.Size = new Size(75, 15);
            lab_kinh_nghiem.TabIndex = 14;
            lab_kinh_nghiem.Text = "Kinh nghiệm";
            // 
            // txt_chuyen_mon
            // 
            txt_chuyen_mon.ForeColor = Color.Red;
            txt_chuyen_mon.Location = new Point(123, 59);
            txt_chuyen_mon.Margin = new Padding(3, 2, 3, 2);
            txt_chuyen_mon.Name = "txt_chuyen_mon";
            txt_chuyen_mon.ReadOnly = true;
            txt_chuyen_mon.Size = new Size(210, 23);
            txt_chuyen_mon.TabIndex = 13;
            // 
            // lab_ma_so
            // 
            lab_ma_so.AutoSize = true;
            lab_ma_so.Location = new Point(27, 62);
            lab_ma_so.Name = "lab_ma_so";
            lab_ma_so.Size = new Size(76, 15);
            lab_ma_so.TabIndex = 12;
            lab_ma_so.Text = "Chuyên môn";
            // 
            // txt_do_tuoi
            // 
            txt_do_tuoi.ForeColor = Color.Red;
            txt_do_tuoi.Location = new Point(465, 97);
            txt_do_tuoi.Margin = new Padding(3, 2, 3, 2);
            txt_do_tuoi.Name = "txt_do_tuoi";
            txt_do_tuoi.ReadOnly = true;
            txt_do_tuoi.Size = new Size(220, 23);
            txt_do_tuoi.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 99);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 18;
            label1.Text = "Độ tuổi";
            // 
            // txt_ky_nang_mem
            // 
            txt_ky_nang_mem.ForeColor = Color.Red;
            txt_ky_nang_mem.Location = new Point(123, 94);
            txt_ky_nang_mem.Margin = new Padding(3, 2, 3, 2);
            txt_ky_nang_mem.Name = "txt_ky_nang_mem";
            txt_ky_nang_mem.ReadOnly = true;
            txt_ky_nang_mem.Size = new Size(210, 23);
            txt_ky_nang_mem.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 97);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 16;
            label2.Text = "Kỹ năng mềm";
            // 
            // txt_ma_so
            // 
            txt_ma_so.ForeColor = Color.Red;
            txt_ma_so.Location = new Point(271, 29);
            txt_ma_so.Margin = new Padding(3, 2, 3, 2);
            txt_ma_so.Name = "txt_ma_so";
            txt_ma_so.Size = new Size(210, 23);
            txt_ma_so.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 32);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 20;
            label3.Text = "Mã số:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { doneToolStripMenuItem, tinhToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // doneToolStripMenuItem
            // 
            doneToolStripMenuItem.Image = (Image)resources.GetObject("doneToolStripMenuItem.Image");
            doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            doneToolStripMenuItem.Size = new Size(85, 24);
            doneToolStripMenuItem.Text = "Hoàn tất";
            doneToolStripMenuItem.Click += doneToolStripMenuItem_Click;
            // 
            // tinhToolStripMenuItem
            // 
            tinhToolStripMenuItem.Image = (Image)resources.GetObject("tinhToolStripMenuItem.Image");
            tinhToolStripMenuItem.Name = "tinhToolStripMenuItem";
            tinhToolStripMenuItem.Size = new Size(62, 24);
            tinhToolStripMenuItem.Text = "Tính";
            tinhToolStripMenuItem.Click += tinhToolStripMenuItem_Click;
            // 
            // NhanSu_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 306);
            Controls.Add(txt_ma_so);
            Controls.Add(label3);
            Controls.Add(txt_do_tuoi);
            Controls.Add(label1);
            Controls.Add(txt_ky_nang_mem);
            Controls.Add(label2);
            Controls.Add(txt_kinh_nghiem);
            Controls.Add(lab_kinh_nghiem);
            Controls.Add(txt_chuyen_mon);
            Controls.Add(lab_ma_so);
            Controls.Add(dtgv_diem);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "NhanSu_Frm";
            Text = "Thêm thông tin nhân sự";
            Load += NhanSu_Frm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_diem).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_diem;
        private TextBox txt_kinh_nghiem;
        private Label lab_kinh_nghiem;
        private TextBox txt_chuyen_mon;
        private Label lab_ma_so;
        private TextBox txt_do_tuoi;
        private Label label1;
        private TextBox txt_ky_nang_mem;
        private Label label2;
        private TextBox txt_ma_so;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem doneToolStripMenuItem;
        private ToolStripMenuItem tinhToolStripMenuItem;
    }
}