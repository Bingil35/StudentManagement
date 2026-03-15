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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_sidebar = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
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
            this.pn_information = new System.Windows.Forms.Panel();
            this.tbox_studentID = new System.Windows.Forms.TextBox();
            this.tbox_StudentName = new System.Windows.Forms.TextBox();
            this.tbox_BirthOfDate = new System.Windows.Forms.TextBox();
            this.tbox_Address = new System.Windows.Forms.TextBox();
            this.tbox_ClassName = new System.Windows.Forms.TextBox();
            this.txt_StudentID = new System.Windows.Forms.Label();
            this.txt_StudentName = new System.Windows.Forms.Label();
            this.txt_BirthOfDate = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_sidebar.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.pn_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).BeginInit();
            this.pn_information.SuspendLayout();
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
            this.pn_content.Controls.Add(this.pn_information);
            this.pn_content.Controls.Add(this.tbox_search);
            this.pn_content.Controls.Add(this.btn_search);
            this.pn_content.Controls.Add(this.dgv_classes);
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(180, 60);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(1404, 781);
            this.pn_content.TabIndex = 0;
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(1069, 20);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(234, 24);
            this.tbox_search.TabIndex = 0;
            this.tbox_search.TextChanged += new System.EventHandler(this.tbox_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1313, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(60, 25);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Tìm";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_classes
            // 
            this.dgv_classes.AllowUserToAddRows = false;
            this.dgv_classes.AllowUserToDeleteRows = false;
            this.dgv_classes.AllowUserToResizeColumns = false;
            this.dgv_classes.AllowUserToResizeRows = false;
            this.dgv_classes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_classes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_classes.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_classes.Location = new System.Drawing.Point(530, 60);
            this.dgv_classes.Name = "dgv_classes";
            this.dgv_classes.Size = new System.Drawing.Size(843, 628);
            this.dgv_classes.TabIndex = 2;
            this.dgv_classes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_classes_CellClick);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Location = new System.Drawing.Point(90, 510);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 35);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.Location = new System.Drawing.Point(190, 510);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 35);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.Location = new System.Drawing.Point(290, 510);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 35);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pn_information
            // 
            this.pn_information.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_information.Controls.Add(this.label5);
            this.pn_information.Controls.Add(this.txt_Address);
            this.pn_information.Controls.Add(this.txt_BirthOfDate);
            this.pn_information.Controls.Add(this.txt_StudentName);
            this.pn_information.Controls.Add(this.btn_add);
            this.pn_information.Controls.Add(this.txt_StudentID);
            this.pn_information.Controls.Add(this.btn_edit);
            this.pn_information.Controls.Add(this.btn_delete);
            this.pn_information.Controls.Add(this.tbox_ClassName);
            this.pn_information.Controls.Add(this.tbox_Address);
            this.pn_information.Controls.Add(this.tbox_BirthOfDate);
            this.pn_information.Controls.Add(this.tbox_StudentName);
            this.pn_information.Controls.Add(this.tbox_studentID);
            this.pn_information.Location = new System.Drawing.Point(21, 60);
            this.pn_information.Name = "pn_information";
            this.pn_information.Size = new System.Drawing.Size(488, 628);
            this.pn_information.TabIndex = 6;
            // 
            // tbox_studentID
            // 
            this.tbox_studentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_studentID.Location = new System.Drawing.Point(119, 30);
            this.tbox_studentID.Name = "tbox_studentID";
            this.tbox_studentID.Size = new System.Drawing.Size(311, 24);
            this.tbox_studentID.TabIndex = 0;
            // 
            // tbox_StudentName
            // 
            this.tbox_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_StudentName.Location = new System.Drawing.Point(119, 100);
            this.tbox_StudentName.Name = "tbox_StudentName";
            this.tbox_StudentName.Size = new System.Drawing.Size(311, 24);
            this.tbox_StudentName.TabIndex = 1;
            // 
            // tbox_BirthOfDate
            // 
            this.tbox_BirthOfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_BirthOfDate.Location = new System.Drawing.Point(119, 170);
            this.tbox_BirthOfDate.Name = "tbox_BirthOfDate";
            this.tbox_BirthOfDate.Size = new System.Drawing.Size(311, 24);
            this.tbox_BirthOfDate.TabIndex = 2;
            // 
            // tbox_Address
            // 
            this.tbox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Address.Location = new System.Drawing.Point(119, 240);
            this.tbox_Address.Name = "tbox_Address";
            this.tbox_Address.Size = new System.Drawing.Size(311, 24);
            this.tbox_Address.TabIndex = 3;
            // 
            // tbox_ClassName
            // 
            this.tbox_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_ClassName.Location = new System.Drawing.Point(119, 310);
            this.tbox_ClassName.Name = "tbox_ClassName";
            this.tbox_ClassName.Size = new System.Drawing.Size(311, 24);
            this.tbox_ClassName.TabIndex = 4;
            // 
            // txt_StudentID
            // 
            this.txt_StudentID.AutoSize = true;
            this.txt_StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentID.Location = new System.Drawing.Point(25, 30);
            this.txt_StudentID.Name = "txt_StudentID";
            this.txt_StudentID.Size = new System.Drawing.Size(50, 18);
            this.txt_StudentID.TabIndex = 5;
            this.txt_StudentID.Text = "MSSV";
            this.txt_StudentID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.AutoSize = true;
            this.txt_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentName.Location = new System.Drawing.Point(25, 100);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(71, 18);
            this.txt_StudentName.TabIndex = 6;
            this.txt_StudentName.Text = "Họ và tên";
            // 
            // txt_BirthOfDate
            // 
            this.txt_BirthOfDate.AutoSize = true;
            this.txt_BirthOfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BirthOfDate.Location = new System.Drawing.Point(25, 170);
            this.txt_BirthOfDate.Name = "txt_BirthOfDate";
            this.txt_BirthOfDate.Size = new System.Drawing.Size(73, 18);
            this.txt_BirthOfDate.TabIndex = 7;
            this.txt_BirthOfDate.Text = "Ngày sinh";
            // 
            // txt_Address
            // 
            this.txt_Address.AutoSize = true;
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(25, 240);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(53, 18);
            this.txt_Address.TabIndex = 8;
            this.txt_Address.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lớp";
            // 
            // form_dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1584, 841);
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
            this.pn_information.ResumeLayout(false);
            this.pn_information.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_logout;
        private Panel pn_information;
        private Label label5;
        private Label txt_Address;
        private Label txt_BirthOfDate;
        private Label txt_StudentName;
        private Label txt_StudentID;
        private TextBox tbox_ClassName;
        private TextBox tbox_Address;
        private TextBox tbox_BirthOfDate;
        private TextBox tbox_StudentName;
        private TextBox tbox_studentID;
    }
}