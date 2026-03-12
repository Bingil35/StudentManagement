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
            this.pn_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(77, 182);
            this.btn_login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 35);
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
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(97, 30);
            this.lb_login.Margin = new System.Windows.Forms.Padding(0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(80, 20);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Đăng nhập";
            this.lb_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // tbox_username
            // 
            this.tbox_username.Location = new System.Drawing.Point(61, 77);
            this.tbox_username.Name = "tbox_username";
            this.tbox_username.Size = new System.Drawing.Size(135, 20);
            this.tbox_username.TabIndex = 2;
            this.tbox_username.TextChanged += new System.EventHandler(this.tbox_username_TextChanged);
            // 
            // tbox_password
            // 
            this.tbox_password.Location = new System.Drawing.Point(61, 128);
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.Size = new System.Drawing.Size(135, 20);
            this.tbox_password.TabIndex = 3;
            // 
            // pn_login
            // 
            this.pn_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_login.Controls.Add(this.lb_login);
            this.pn_login.Controls.Add(this.btn_login);
            this.pn_login.Controls.Add(this.tbox_password);
            this.pn_login.Controls.Add(this.tbox_username);
            this.pn_login.Location = new System.Drawing.Point(273, 84);
            this.pn_login.Margin = new System.Windows.Forms.Padding(0);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(250, 250);
            this.pn_login.TabIndex = 4;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_login);
            this.Name = "form_login";
            this.Text = "Đăng nhập";
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
    }
}

