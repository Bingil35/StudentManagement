using System.Windows.Forms;

namespace StudentManagement
{
    partial class form_login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.tbox_username = new System.Windows.Forms.TextBox();
            this.tbox_password = new System.Windows.Forms.TextBox();
            this.pn_login = new System.Windows.Forms.Panel();
            this.chbox_remember = new System.Windows.Forms.CheckBox();
            this.pn_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(140, 220);
            this.btn_login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 45);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_login
            // 
            this.lb_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(135, 31);
            this.lb_login.Margin = new System.Windows.Forms.Padding(0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(137, 30);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Đăng nhập";
            this.lb_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // tbox_username
            // 
            this.tbox_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbox_username.Location = new System.Drawing.Point(70, 90);
            this.tbox_username.Name = "tbox_username";
            this.tbox_username.Size = new System.Drawing.Size(260, 27);
            this.tbox_username.TabIndex = 2;
            this.tbox_username.TextChanged += new System.EventHandler(this.tbox_username_TextChanged);
            // 
            // tbox_password
            // 
            this.tbox_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbox_password.Location = new System.Drawing.Point(70, 140);
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.Size = new System.Drawing.Size(260, 27);
            this.tbox_password.TabIndex = 3;
            this.tbox_password.UseSystemPasswordChar = true;
            // 
            // pn_login
            // 
            this.pn_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_login.Controls.Add(this.chbox_remember);
            this.pn_login.Controls.Add(this.lb_login);
            this.pn_login.Controls.Add(this.btn_login);
            this.pn_login.Controls.Add(this.tbox_password);
            this.pn_login.Controls.Add(this.tbox_username);
            this.pn_login.Location = new System.Drawing.Point(200, 70);
            this.pn_login.Margin = new System.Windows.Forms.Padding(0);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(400, 320);
            this.pn_login.TabIndex = 4;
            this.pn_login.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_login_Paint);
            // 
            // chbox_remember
            // 
            this.chbox_remember.AutoSize = true;
            this.chbox_remember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chbox_remember.Location = new System.Drawing.Point(70, 180);
            this.chbox_remember.Name = "chbox_remember";
            this.chbox_remember.Size = new System.Drawing.Size(107, 19);
            this.chbox_remember.TabIndex = 4;
            this.chbox_remember.Text = "Nhớ mật khẩu?";
            this.chbox_remember.UseVisualStyleBackColor = true;
            this.chbox_remember.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_login);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tbox_username;
        private System.Windows.Forms.TextBox tbox_password;
        private System.Windows.Forms.Panel pn_login;
        private System.Windows.Forms.CheckBox chbox_remember;
    }
}

