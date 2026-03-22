using System.Windows.Forms;

namespace StudentManagement
{
    partial class form_dashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pn_sidebar;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Panel pn_content;

        private System.Windows.Forms.Button btn_students;
        private System.Windows.Forms.Button btn_classes;

        private System.Windows.Forms.Label lb_title;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pn_sidebar = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_students = new System.Windows.Forms.Button();
            this.btn_classes = new System.Windows.Forms.Button();
            this.pn_header = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.pn_sidebar.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.pn_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_sidebar
            // 
            this.pn_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pn_sidebar.Controls.Add(this.btn_logout);
            this.pn_sidebar.Controls.Add(this.btn_students);
            this.pn_sidebar.Controls.Add(this.btn_classes);
            this.pn_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pn_sidebar.Name = "pn_sidebar";
            this.pn_sidebar.Size = new System.Drawing.Size(180, 841);
            this.pn_sidebar.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(20, 180);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(140, 40);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_students
            // 
            this.btn_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_students.ForeColor = System.Drawing.Color.White;
            this.btn_students.Location = new System.Drawing.Point(20, 80);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(140, 40);
            this.btn_students.TabIndex = 0;
            this.btn_students.Text = "Trang chủ";
            this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
            // 
            // btn_classes
            // 
            this.btn_classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_classes.ForeColor = System.Drawing.Color.White;
            this.btn_classes.Location = new System.Drawing.Point(20, 130);
            this.btn_classes.Name = "btn_classes";
            this.btn_classes.Size = new System.Drawing.Size(140, 40);
            this.btn_classes.TabIndex = 1;
            this.btn_classes.Text = "Quản lý lớp học";
            this.btn_classes.Click += new System.EventHandler(this.btn_classes_Click);
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_header.Controls.Add(this.lb_title);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1404, 60);
            this.pn_header.TabIndex = 1;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lb_title.Location = new System.Drawing.Point(592, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(270, 25);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Trang chủ - Quản lý sinh viên";
            // 
            // pn_content
            // 
            this.pn_content.BackColor = System.Drawing.Color.White;
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 60);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(1404, 781);
            this.pn_content.TabIndex = 0;
            // 
            // pn_Main
            // 
            this.pn_Main.Controls.Add(this.pn_content);
            this.pn_Main.Controls.Add(this.pn_header);
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main.Location = new System.Drawing.Point(180, 0);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(1404, 841);
            this.pn_Main.TabIndex = 1;
            this.pn_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Main_Paint);
            // 
            // form_dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1584, 841);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.pn_sidebar);
            this.Name = "form_dashboard";
            this.Text = "Dashboard";
            this.pn_sidebar.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_logout;
        private Panel pn_Main;
    }
}