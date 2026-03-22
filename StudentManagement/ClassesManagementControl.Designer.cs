using System.Windows.Forms;

namespace StudentManagement
{
    partial class ClassesManagementControl
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
            this.pn_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.pn_information = new System.Windows.Forms.Panel();
            this.lb_Capacity = new System.Windows.Forms.Label();
            this.tbox_Capacity = new System.Windows.Forms.TextBox();
            this.lb_ClassID = new System.Windows.Forms.Label();
            this.tbox_ClassID = new System.Windows.Forms.TextBox();
            this.lb_ClassName = new System.Windows.Forms.Label();
            this.tbox_ClassName = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_classes = new System.Windows.Forms.DataGridView();
            this.pn_header.SuspendLayout();
            this.pn_content.SuspendLayout();
            this.pn_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.Controls.Add(this.label1);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1404, 60);
            this.pn_header.TabIndex = 0;
            this.pn_header.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_header_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý lớp";
            // 
            // pn_content
            // 
            this.pn_content.Controls.Add(this.pn_information);
            this.pn_content.Controls.Add(this.dgv_classes);
            this.pn_content.Location = new System.Drawing.Point(3, 69);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(1404, 781);
            this.pn_content.TabIndex = 1;
            // 
            // pn_information
            // 
            this.pn_information.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_information.Controls.Add(this.lb_Capacity);
            this.pn_information.Controls.Add(this.tbox_Capacity);
            this.pn_information.Controls.Add(this.lb_ClassID);
            this.pn_information.Controls.Add(this.tbox_ClassID);
            this.pn_information.Controls.Add(this.lb_ClassName);
            this.pn_information.Controls.Add(this.tbox_ClassName);
            this.pn_information.Controls.Add(this.btn_add);
            this.pn_information.Controls.Add(this.btn_edit);
            this.pn_information.Controls.Add(this.btn_delete);
            this.pn_information.Location = new System.Drawing.Point(30, 30);
            this.pn_information.Name = "pn_information";
            this.pn_information.Size = new System.Drawing.Size(400, 600);
            this.pn_information.TabIndex = 0;
            // 
            // lb_Capacity
            // 
            this.lb_Capacity.Location = new System.Drawing.Point(20, 145);
            this.lb_Capacity.Name = "lb_Capacity";
            this.lb_Capacity.Size = new System.Drawing.Size(100, 23);
            this.lb_Capacity.TabIndex = 7;
            this.lb_Capacity.Text = "Sĩ số";
            // 
            // tbox_Capacity
            // 
            this.tbox_Capacity.Location = new System.Drawing.Point(120, 145);
            this.tbox_Capacity.Name = "tbox_Capacity";
            this.tbox_Capacity.Size = new System.Drawing.Size(220, 20);
            this.tbox_Capacity.TabIndex = 8;
            // 
            // lb_ClassID
            // 
            this.lb_ClassID.Location = new System.Drawing.Point(20, 30);
            this.lb_ClassID.Name = "lb_ClassID";
            this.lb_ClassID.Size = new System.Drawing.Size(100, 23);
            this.lb_ClassID.TabIndex = 0;
            this.lb_ClassID.Text = "Mã lớp";
            // 
            // tbox_ClassID
            // 
            this.tbox_ClassID.Location = new System.Drawing.Point(120, 30);
            this.tbox_ClassID.Name = "tbox_ClassID";
            this.tbox_ClassID.Size = new System.Drawing.Size(220, 20);
            this.tbox_ClassID.TabIndex = 1;
            // 
            // lb_ClassName
            // 
            this.lb_ClassName.Location = new System.Drawing.Point(20, 90);
            this.lb_ClassName.Name = "lb_ClassName";
            this.lb_ClassName.Size = new System.Drawing.Size(100, 23);
            this.lb_ClassName.TabIndex = 2;
            this.lb_ClassName.Text = "Tên lớp";
            // 
            // tbox_ClassName
            // 
            this.tbox_ClassName.Location = new System.Drawing.Point(120, 90);
            this.tbox_ClassName.Name = "tbox_ClassName";
            this.tbox_ClassName.Size = new System.Drawing.Size(220, 20);
            this.tbox_ClassName.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(50, 200);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(150, 200);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(250, 200);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_classes
            // 
            this.dgv_classes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_classes.Location = new System.Drawing.Point(450, 30);
            this.dgv_classes.Name = "dgv_classes";
            this.dgv_classes.Size = new System.Drawing.Size(900, 600);
            this.dgv_classes.TabIndex = 1;
            this.dgv_classes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_classes_CellClick);

            // ===== SEARCH BOX =====
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.tbox_search.Location = new System.Drawing.Point(950, 5);
            this.tbox_search.Size = new System.Drawing.Size(250, 20);

            // ===== SEARCH BUTTON =====
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_search.Text = "Tìm";
            this.btn_search.Location = new System.Drawing.Point(1210, 3);
            this.btn_search.Size = new System.Drawing.Size(60, 25);
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);

            this.pn_content.Controls.Add(this.tbox_search);
            this.pn_content.Controls.Add(this.btn_search);
            // 
            // ClassesManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_content);
            this.Controls.Add(this.pn_header);
            this.Name = "ClassesManagementControl";
            this.Size = new System.Drawing.Size(1404, 841);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_content.ResumeLayout(false);
            this.pn_information.ResumeLayout(false);
            this.pn_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_information;
        private System.Windows.Forms.Label lb_ClassID;
        private System.Windows.Forms.Label lb_ClassName;

        private System.Windows.Forms.TextBox tbox_ClassID;
        private System.Windows.Forms.TextBox tbox_ClassName;

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;

        private System.Windows.Forms.DataGridView dgv_classes;
        private System.Windows.Forms.Label lb_Capacity;
        private System.Windows.Forms.TextBox tbox_Capacity;

        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Button btn_search;
    }
}
