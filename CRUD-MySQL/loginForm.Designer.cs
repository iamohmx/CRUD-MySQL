namespace CRUD_MySQL
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginLabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitProgram = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("TH SarabunPSK", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.loginLabel.Location = new System.Drawing.Point(259, 169);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(145, 48);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "เข้าสู่ระบบ";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Prompt", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtUsername.Location = new System.Drawing.Point(216, 232);
            this.txtUsername.MaxLength = 80;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 35);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Prompt Bold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPassword.Location = new System.Drawing.Point(216, 271);
            this.txtPassword.MaxLength = 80;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(226, 35);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.AutoSize = true;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginBtn.Font = new System.Drawing.Font("TH SarabunPSK", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.loginBtn.Location = new System.Drawing.Point(216, 355);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(94, 38);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "เข้าสู่ระบบ";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitProgram.AutoSize = true;
            this.exitProgram.BackColor = System.Drawing.Color.Red;
            this.exitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitProgram.Font = new System.Drawing.Font("TH SarabunPSK", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.exitProgram.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitProgram.Location = new System.Drawing.Point(256, 413);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(135, 38);
            this.exitProgram.TabIndex = 4;
            this.exitProgram.Text = "ออกจากโปรแกรม";
            this.exitProgram.UseVisualStyleBackColor = false;
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // regBtn
            // 
            this.regBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regBtn.AutoSize = true;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.regBtn.Font = new System.Drawing.Font("TH SarabunPSK", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.regBtn.Location = new System.Drawing.Point(337, 355);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(107, 38);
            this.regBtn.TabIndex = 5;
            this.regBtn.Text = "สมัครสมาชิก";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(154, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "ชื่อผู้ใช้";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH SarabunPSK", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(146, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "รหัสผ่าน";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.loginLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitProgram;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}