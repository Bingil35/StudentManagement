using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class ClassesManagementControl : UserControl
    {
        public ClassesManagementControl()
        {
            InitializeComponent();
            load_data();
        }

        private void pn_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load_data()
        {
            DataBaseDataContext db = new DataBaseDataContext();

            dgv_classes.DataSource = db.Classes.ToList();

            dgv_classes.Columns["ClassID"].HeaderText = "Mã lớp";
            dgv_classes.Columns["ClassName"].HeaderText = "Tên lớp";
            dgv_classes.Columns["Capacity"].HeaderText = "Sĩ số";
        }

        private void dgv_classes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_classes.Rows[e.RowIndex];

            tbox_ClassID.Text = row.Cells["ClassID"].Value.ToString();
            tbox_ClassName.Text = row.Cells["ClassName"].Value.ToString();
            tbox_Capacity.Text = row.Cells["Capacity"].Value.ToString();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbox_ClassID.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!");
                return false;
            }

            if (!int.TryParse(tbox_ClassID.Text, out _))
            {
                MessageBox.Show("Mã lớp phải là số!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbox_ClassName.Text))
            {
                MessageBox.Show("Tên lớp không được để trống!");
                return false;
            }

            // Capacity
            if (string.IsNullOrWhiteSpace(tbox_Capacity.Text))
            {
                MessageBox.Show("Sức chứa không được để trống!");
                return false;
            }

            if (!int.TryParse(tbox_Capacity.Text, out int capacity))
            {
                MessageBox.Show("Sĩ số phải là số!");
                return false;
            }

            if (capacity <= 0)
            {
                MessageBox.Show("Sĩ số phải > 0!");
                return false;
            }

            return true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            DataBaseDataContext db = new DataBaseDataContext();

            int id = int.Parse(tbox_ClassID.Text);
            int capacity = int.Parse(tbox_Capacity.Text);

            if (db.Classes.Any(c => c.ClassID == id))
            {
                MessageBox.Show("Mã lớp đã tồn tại!");
                return;
            }

            Class newClass = new Class
            {
                ClassID = id,
                ClassName = tbox_ClassName.Text.Trim(),
                Capacity = capacity
            };

            db.Classes.InsertOnSubmit(newClass);
            db.SubmitChanges();

            MessageBox.Show("Thêm lớp thành công!");
            load_data();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            DataBaseDataContext db = new DataBaseDataContext();

            int id = int.Parse(tbox_ClassID.Text);
            int capacity = int.Parse(tbox_Capacity.Text);

            var cls = db.Classes.FirstOrDefault(c => c.ClassID == id);

            if (cls == null)
            {
                MessageBox.Show("Không tìm thấy lớp!");
                return;
            }

            cls.ClassName = tbox_ClassName.Text.Trim();
            cls.Capacity = capacity;

            db.SubmitChanges();

            MessageBox.Show("Cập nhật thành công!");
            load_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbox_ClassID.Text, out int id))
            {
                MessageBox.Show("Mã lớp không hợp lệ!");
                return;
            }

            DataBaseDataContext db = new DataBaseDataContext();

            var cls = db.Classes.FirstOrDefault(c => c.ClassID == id);

            if (cls == null)
            {
                MessageBox.Show("Không tìm thấy lớp!");
                return;
            }

            if (db.Students.Any(s => s.ClassID == id))
            {
                MessageBox.Show("Không thể xóa lớp đang có sinh viên!");
                return;
            }

            db.Classes.DeleteOnSubmit(cls);
            db.SubmitChanges();

            MessageBox.Show("Xóa thành công!");
            load_data();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = tbox_search.Text.Trim();

            DataBaseDataContext db = new DataBaseDataContext();

            var query = db.Classes.Where(c =>
                c.ClassName.Contains(keyword) ||
                c.ClassID.ToString().Contains(keyword)
            );

            dgv_classes.DataSource = query.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
