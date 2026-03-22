using System.Windows.Forms;

namespace StudentManagement
{
    partial class StudentManagementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_header = new System.Windows.Forms.Panel();
            this.lb_header = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_classes = new System.Windows.Forms.DataGridView();
            this.pn_information = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.Label();
            this.txt_BirthOfDate = new System.Windows.Forms.Label();
            this.txt_StudentName = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_StudentID = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tbox_ClassName = new System.Windows.Forms.TextBox();
            this.tbox_Address = new System.Windows.Forms.TextBox();
            this.dtp_BirthOfDate = new System.Windows.Forms.DateTimePicker();
            this.tbox_StudentName = new System.Windows.Forms.TextBox();
            this.tbox_studentID = new System.Windows.Forms.TextBox();
            this.pn_header.SuspendLayout();
            this.pn_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).BeginInit();
            this.pn_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.Controls.Add(this.lb_header);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1404, 60);
            this.pn_header.TabIndex = 0;
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.Location = new System.Drawing.Point(621, 20);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(144, 20);
            this.lb_header.TabIndex = 0;
            this.lb_header.Text = "Quản lý sinh viên";
            // 
            // pn_content
            // 
            this.pn_content.Controls.Add(this.tbox_search);
            this.pn_content.Controls.Add(this.btn_search);
            this.pn_content.Controls.Add(this.dgv_classes);
            this.pn_content.Controls.Add(this.pn_information);
            this.pn_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_content.Location = new System.Drawing.Point(0, 60);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(1404, 781);
            this.pn_content.TabIndex = 1;
            // 
            // tbox_search
            // 
            this.tbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.Location = new System.Drawing.Point(1073, 22);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(234, 24);
            this.tbox_search.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1317, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(60, 25);
            this.btn_search.TabIndex = 10;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_classes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_classes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_classes.Location = new System.Drawing.Point(537, 52);
            this.dgv_classes.Name = "dgv_classes";
            this.dgv_classes.Size = new System.Drawing.Size(843, 628);
            this.dgv_classes.TabIndex = 8;
            this.dgv_classes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_classes_CellClick);
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
            this.pn_information.Controls.Add(this.dtp_BirthOfDate);
            this.pn_information.Controls.Add(this.tbox_StudentName);
            this.pn_information.Controls.Add(this.tbox_studentID);
            this.pn_information.Location = new System.Drawing.Point(43, 52);
            this.pn_information.Name = "pn_information";
            this.pn_information.Size = new System.Drawing.Size(488, 628);
            this.pn_information.TabIndex = 7;
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
            // txt_StudentID
            // 
            this.txt_StudentID.AutoSize = true;
            this.txt_StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentID.Location = new System.Drawing.Point(25, 30);
            this.txt_StudentID.Name = "txt_StudentID";
            this.txt_StudentID.Size = new System.Drawing.Size(50, 18);
            this.txt_StudentID.TabIndex = 5;
            this.txt_StudentID.Text = "MSSV";
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
            // tbox_ClassName
            // 
            this.tbox_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_ClassName.Location = new System.Drawing.Point(119, 310);
            this.tbox_ClassName.Name = "tbox_ClassName";
            this.tbox_ClassName.Size = new System.Drawing.Size(311, 24);
            this.tbox_ClassName.TabIndex = 4;
            // 
            // tbox_Address
            // 
            this.tbox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Address.Location = new System.Drawing.Point(119, 240);
            this.tbox_Address.Name = "tbox_Address";
            this.tbox_Address.Size = new System.Drawing.Size(311, 24);
            this.tbox_Address.TabIndex = 3;
            // 
            // dtp_BirthOfDate
            // 
            this.dtp_BirthOfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtp_BirthOfDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BirthOfDate.Location = new System.Drawing.Point(119, 170);
            this.dtp_BirthOfDate.Name = "dtp_BirthOfDate";
            this.dtp_BirthOfDate.Size = new System.Drawing.Size(311, 24);
            this.dtp_BirthOfDate.TabIndex = 10;
            // 
            // tbox_StudentName
            // 
            this.tbox_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_StudentName.Location = new System.Drawing.Point(119, 100);
            this.tbox_StudentName.Name = "tbox_StudentName";
            this.tbox_StudentName.Size = new System.Drawing.Size(311, 24);
            this.tbox_StudentName.TabIndex = 1;
            // 
            // tbox_studentID
            // 
            this.tbox_studentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_studentID.Location = new System.Drawing.Point(119, 30);
            this.tbox_studentID.Name = "tbox_studentID";
            this.tbox_studentID.Size = new System.Drawing.Size(311, 24);
            this.tbox_studentID.TabIndex = 0;
            // 
            // StudentManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_content);
            this.Controls.Add(this.pn_header);
            this.Name = "StudentManagementControl";
            this.Size = new System.Drawing.Size(1404, 841);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_content.ResumeLayout(false);
            this.pn_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).EndInit();
            this.pn_information.ResumeLayout(false);
            this.pn_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Label lb_header;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.Panel pn_information;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_Address;
        private System.Windows.Forms.Label txt_BirthOfDate;
        private System.Windows.Forms.Label txt_StudentName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label txt_StudentID;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tbox_ClassName;
        private System.Windows.Forms.TextBox tbox_Address;
        private System.Windows.Forms.DateTimePicker dtp_BirthOfDate;
        private System.Windows.Forms.TextBox tbox_StudentName;
        private System.Windows.Forms.TextBox tbox_studentID;
        private System.Windows.Forms.DataGridView dgv_classes;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Button btn_search;
    }
}
