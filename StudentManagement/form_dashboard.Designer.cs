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

        private System.Windows.Forms.DataGridView dgv_classes;

        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Button btn_search;

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;

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
            this.btn_students = new System.Windows.Forms.Button();
            this.btn_classes = new System.Windows.Forms.Button();
            this.pn_header = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_classes = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pn_sidebar.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.pn_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).BeginInit();
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
            this.pn_sidebar.Size = new System.Drawing.Size(180, 500);
            this.pn_sidebar.TabIndex = 2;
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
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_header.Controls.Add(this.lb_title);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(180, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(820, 60);
            this.pn_header.TabIndex = 1;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lb_title.Location = new System.Drawing.Point(200, 15);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(270, 25);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Trang chủ - Quản lý sinh viên";
            // 
            // pn_content
            // 
            this.pn_content.BackColor = System.Drawing.Color.White;
            this.pn_content.Controls.Add(this.tbox_search);
            this.pn_content.Controls.Add(this.btn_search);
            this.pn_content.Controls.Add(this.dgv_classes);
            this.pn_content.Controls.Add(this.btn_add);
            this.pn_content.Controls.Add(this.btn_edit);
            this.pn_content.Controls.Add(this.btn_delete);
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(180, 60);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(820, 440);
            this.pn_content.TabIndex = 0;
            // 
            // tbox_search
            // 
            this.tbox_search.Location = new System.Drawing.Point(500, 20);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(180, 20);
            this.tbox_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(690, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(60, 25);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Tìm";
            // 
            // dgv_classes
            // 
            this.dgv_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classes.Location = new System.Drawing.Point(20, 60);
            this.dgv_classes.Name = "dgv_classes";
            this.dgv_classes.Size = new System.Drawing.Size(730, 280);
            this.dgv_classes.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Location = new System.Drawing.Point(20, 360);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 35);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.Location = new System.Drawing.Point(120, 360);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 35);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.Location = new System.Drawing.Point(220, 360);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 35);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
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
            // 
            // form_dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pn_content);
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.pn_sidebar);
            this.Name = "form_dashboard";
            this.Text = "Dashboard";
            this.pn_sidebar.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_content.ResumeLayout(false);
            this.pn_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_logout;
    }
}