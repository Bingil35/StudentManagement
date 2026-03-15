using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class form_dashboard : Form
    {
        public form_dashboard()
        {
            InitializeComponent();
            this.Load += form_dashboard_Load;
        }

        private void form_dashboard_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var query = from s in db.Students
                        join c in db.Classes on s.ClassID equals c.ClassID
                        select new
                        {
                            s.StudentID,
                            s.StudentName,
                            s.BirthOfDate,
                            s.Address,
                            ClassName = c.ClassName
                        };
            dgv_classes.DataSource = query.ToList();
            dgv_classes.Columns["StudentID"].HeaderText = "MSSV";
            dgv_classes.Columns["StudentName"].HeaderText = "Họ và tên";
            dgv_classes.Columns["BirthOfDate"].HeaderText = "Ngày sinh";
            dgv_classes.Columns["Address"].HeaderText = "Địa chỉ";
            dgv_classes.Columns["ClassName"].HeaderText = "Lớp";
        }

        private void dgv_classes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbox_studentID.Text = dgv_classes.CurrentRow.Cells["StudentID"].Value.ToString();
            tbox_StudentName.Text = dgv_classes.CurrentRow.Cells["StudentName"].Value.ToString();
            tbox_BirthOfDate.Text = dgv_classes.CurrentRow.Cells["BirthOfDate"].Value.ToString();
            tbox_Address.Text = dgv_classes.CurrentRow.Cells["Address"].Value.ToString();
            tbox_ClassName.Text = dgv_classes.CurrentRow.Cells["ClassName"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            Student newStudent = new Student
            {
                StudentID = int.Parse(tbox_studentID.Text),
                StudentName = tbox_StudentName.Text,
                BirthOfDate = tbox_BirthOfDate.Text,
                Address = tbox_Address.Text,
            };

            db.Students.InsertOnSubmit(newStudent);
            db.SubmitChanges();
            MessageBox.Show("Thêm sinh viên thành công!");
            load_data();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            int studentID = int.Parse(tbox_studentID.Text);
            Student studentToUpdate = db.Students.FirstOrDefault(s => s.StudentID == studentID);

            if (studentToUpdate != null)
            {
                studentToUpdate.StudentName = tbox_StudentName.Text;
                studentToUpdate.BirthOfDate = tbox_BirthOfDate.Text;
                studentToUpdate.Address = tbox_Address.Text;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật sinh viên thành công!");
                load_data();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            int studentID = int.Parse(tbox_studentID.Text);
            Student studentToDelete = db.Students.FirstOrDefault(s => s.StudentID == studentID);
            if (studentToDelete != null) {
                db.Students.DeleteOnSubmit(studentToDelete);
                db.SubmitChanges();
                MessageBox.Show("Xóa sinh viên thành công!");
                load_data();
            }
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            tbox_search.Text = tbox_search.Text.Trim();

            DataBaseDataContext db = new DataBaseDataContext();
            var query = from s in db.Students
                        join c in db.Classes on s.ClassID equals c.ClassID
                        where s.StudentName.Contains(tbox_search.Text) || c.ClassName.Contains(tbox_search.Text)
                        select new
                        {
                            s.StudentID,
                            s.StudentName,
                            s.BirthOfDate,
                            s.Address,
                            ClassName = c.ClassName
                        };
            dgv_classes.DataSource = query.ToList();

        }
    }
}
