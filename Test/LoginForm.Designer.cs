namespace Test.Properties
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bt_Login = new System.Windows.Forms.Button();
            this.tb_UserPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_LoginGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.White;
            this.bt_Login.Image = ((System.Drawing.Image)(resources.GetObject("bt_Login.Image")));
            this.bt_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Login.Location = new System.Drawing.Point(317, 234);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_Login.Size = new System.Drawing.Size(182, 47);
            this.bt_Login.TabIndex = 55;
            this.bt_Login.Text = "Login";
            this.bt_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // tb_UserPassword
            // 
            this.tb_UserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_UserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_UserPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tb_UserPassword.Location = new System.Drawing.Point(291, 173);
            this.tb_UserPassword.Multiline = true;
            this.tb_UserPassword.Name = "tb_UserPassword";
            this.tb_UserPassword.PasswordChar = '*';
            this.tb_UserPassword.Size = new System.Drawing.Size(221, 20);
            this.tb_UserPassword.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "Password:";
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Username.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Username.Location = new System.Drawing.Point(291, 135);
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(221, 20);
            this.tb_Username.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Username:";
            // 
            // bt_LoginGuest
            // 
            this.bt_LoginGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_LoginGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LoginGuest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoginGuest.ForeColor = System.Drawing.Color.White;
            this.bt_LoginGuest.Image = ((System.Drawing.Image)(resources.GetObject("bt_LoginGuest.Image")));
            this.bt_LoginGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_LoginGuest.Location = new System.Drawing.Point(317, 298);
            this.bt_LoginGuest.Name = "bt_LoginGuest";
            this.bt_LoginGuest.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bt_LoginGuest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_LoginGuest.Size = new System.Drawing.Size(182, 47);
            this.bt_LoginGuest.TabIndex = 56;
            this.bt_LoginGuest.Text = "Login as Guest";
            this.bt_LoginGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_LoginGuest.UseVisualStyleBackColor = true;
            this.bt_LoginGuest.Click += new System.EventHandler(this.bt_LoginGuest_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_LoginGuest);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_UserPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.TextBox tb_UserPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_LoginGuest;
    }
}