namespace StudentManagement
{
    partial class form_managementClasses
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.Button btn_search;

        private System.Windows.Forms.DataGridView dgv_classes;

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;

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
            this.lb_title = new System.Windows.Forms.Label();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();

            this.dgv_classes = new System.Windows.Forms.DataGridView();

            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).BeginInit();
            this.SuspendLayout();

            // TITLE
            this.lb_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lb_title.Location = new System.Drawing.Point(20, 10);
            this.lb_title.Size = new System.Drawing.Size(350, 40);
            this.lb_title.Text = "Quản lý danh sách lớp học";

            // SEARCH BOX
            this.tbox_search.Location = new System.Drawing.Point(520, 20);
            this.tbox_search.Size = new System.Drawing.Size(180, 22);

            // SEARCH BUTTON
            this.btn_search.Location = new System.Drawing.Point(710, 18);
            this.btn_search.Size = new System.Drawing.Size(70, 26);
            this.btn_search.Text = "Tìm";

            // DATAGRIDVIEW
            this.dgv_classes.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgv_classes.Location = new System.Drawing.Point(20, 60);
            this.dgv_classes.Size = new System.Drawing.Size(760, 300);
            this.dgv_classes.Name = "dgv_classes";

            // BUTTON ADD
            this.btn_add.Location = new System.Drawing.Point(20, 380);
            this.btn_add.Size = new System.Drawing.Size(100, 35);
            this.btn_add.Text = "Thêm lớp";

            // BUTTON EDIT
            this.btn_edit.Location = new System.Drawing.Point(130, 380);
            this.btn_edit.Size = new System.Drawing.Size(100, 35);
            this.btn_edit.Text = "Sửa lớp";

            // BUTTON DELETE
            this.btn_delete.Location = new System.Drawing.Point(240, 380);
            this.btn_delete.Size = new System.Drawing.Size(100, 35);
            this.btn_delete.Text = "Xóa lớp";

            // FORM
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.tbox_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_classes);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);

            this.Text = "Quản lý lớp học";

            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}