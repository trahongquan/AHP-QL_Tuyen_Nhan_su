namespace AHP
{
    partial class GiamKhao_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiamKhao_Frm));
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            txt_trong_so = new TextBox();
            lab_chuyen_mon = new Label();
            txt_ma_so = new TextBox();
            lab_ma_so = new Label();
            dtgv_gk = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_gk).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = (Image)resources.GetObject("addToolStripMenuItem.Image");
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(61, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(59, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(72, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // txt_trong_so
            // 
            txt_trong_so.ForeColor = Color.Red;
            txt_trong_so.Location = new Point(639, 43);
            txt_trong_so.Name = "txt_trong_so";
            txt_trong_so.Size = new Size(275, 26);
            txt_trong_so.TabIndex = 9;
            // 
            // lab_chuyen_mon
            // 
            lab_chuyen_mon.AutoSize = true;
            lab_chuyen_mon.Location = new Point(538, 46);
            lab_chuyen_mon.Name = "lab_chuyen_mon";
            lab_chuyen_mon.Size = new Size(66, 19);
            lab_chuyen_mon.TabIndex = 8;
            lab_chuyen_mon.Text = "Trọng số:";
            // 
            // txt_ma_so
            // 
            txt_ma_so.ForeColor = Color.Red;
            txt_ma_so.Location = new Point(169, 43);
            txt_ma_so.Name = "txt_ma_so";
            txt_ma_so.Size = new Size(297, 26);
            txt_ma_so.TabIndex = 7;
            // 
            // lab_ma_so
            // 
            lab_ma_so.AutoSize = true;
            lab_ma_so.Location = new Point(87, 46);
            lab_ma_so.Name = "lab_ma_so";
            lab_ma_so.Size = new Size(50, 19);
            lab_ma_so.TabIndex = 6;
            lab_ma_so.Text = "Mã số:";
            // 
            // dtgv_gk
            // 
            dtgv_gk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_gk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_gk.Location = new Point(12, 99);
            dtgv_gk.Name = "dtgv_gk";
            dtgv_gk.ReadOnly = true;
            dtgv_gk.RowHeadersWidth = 51;
            dtgv_gk.RowTemplate.Height = 29;
            dtgv_gk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_gk.Size = new Size(976, 407);
            dtgv_gk.TabIndex = 10;
            dtgv_gk.RowEnter += dtgv_gk_RowEnter;
            // 
            // GiamKhao_Frm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 518);
            Controls.Add(dtgv_gk);
            Controls.Add(txt_trong_so);
            Controls.Add(lab_chuyen_mon);
            Controls.Add(txt_ma_so);
            Controls.Add(lab_ma_so);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GiamKhao_Frm";
            Text = "GiamKhao_Frm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_gk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TextBox txt_trong_so;
        private Label lab_chuyen_mon;
        private TextBox txt_ma_so;
        private Label lab_ma_so;
        private DataGridView dtgv_gk;
    }
}