namespace AHP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lab_tit = new Label();
            lab_user = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            lab_pass = new Label();
            btn_ok = new Button();
            btn_esc = new Button();
            SuspendLayout();
            // 
            // lab_tit
            // 
            lab_tit.AutoSize = true;
            lab_tit.BackColor = Color.Transparent;
            lab_tit.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lab_tit.ForeColor = Color.Yellow;
            lab_tit.Location = new Point(322, 9);
            lab_tit.Name = "lab_tit";
            lab_tit.Size = new Size(230, 54);
            lab_tit.TabIndex = 0;
            lab_tit.Text = "Đăng nhập";
            // 
            // lab_user
            // 
            lab_user.AutoSize = true;
            lab_user.BackColor = Color.Transparent;
            lab_user.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_user.ForeColor = Color.Gold;
            lab_user.Location = new Point(34, 135);
            lab_user.Name = "lab_user";
            lab_user.Size = new Size(200, 50);
            lab_user.TabIndex = 1;
            lab_user.Text = "Tài khoản:";
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(269, 133);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(433, 57);
            txt_user.TabIndex = 2;
            txt_user.Text = "nhom_4";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(269, 207);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(433, 57);
            txt_pass.TabIndex = 4;
            txt_pass.Text = "123456";
            txt_pass.UseSystemPasswordChar = true;
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.BackColor = Color.Transparent;
            lab_pass.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_pass.ForeColor = Color.Gold;
            lab_pass.Location = new Point(34, 209);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(186, 50);
            lab_pass.TabIndex = 3;
            lab_pass.Text = "Mật khẩu";
            // 
            // btn_ok
            // 
            btn_ok.BackColor = Color.RoyalBlue;
            btn_ok.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = SystemColors.ButtonHighlight;
            btn_ok.Location = new Point(315, 331);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(142, 60);
            btn_ok.TabIndex = 5;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_esc
            // 
            btn_esc.BackColor = Color.RoyalBlue;
            btn_esc.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_esc.ForeColor = SystemColors.ButtonHighlight;
            btn_esc.Location = new Point(463, 331);
            btn_esc.Name = "btn_esc";
            btn_esc.Size = new Size(143, 60);
            btn_esc.TabIndex = 6;
            btn_esc.Text = "Thoát";
            btn_esc.UseVisualStyleBackColor = false;
            btn_esc.Click += btn_esc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_esc);
            Controls.Add(btn_ok);
            Controls.Add(txt_pass);
            Controls.Add(lab_pass);
            Controls.Add(txt_user);
            Controls.Add(lab_user);
            Controls.Add(lab_tit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_tit;
        private Label lab_user;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Label lab_pass;
        private Button btn_ok;
        private Button btn_esc;
    }
}