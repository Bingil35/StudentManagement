using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StudentManagementControl : UserControl
    {
        public StudentManagementControl()
        {
            InitializeComponent();
            this.Load += Control_StudentManagement_Load;
        }

        private void Control_StudentManagement_Load(object sender, EventArgs e)
        {
            // load UI/UX
            SetRoundedRegion(pn_information, 20);
            SetRoundedRegion(btn_add, 10);
            SetRoundedRegion(btn_edit, 10);
            SetRoundedRegion(btn_delete, 10);
            SetRoundedRegion(btn_search, 10);

            // load data
            load_data();
        }
        public void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
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
            if (dgv_classes.CurrentRow != null)
            {
                tbox_studentID.Text = dgv_classes.CurrentRow.Cells["StudentID"].Value.ToString();
                tbox_StudentName.Text = dgv_classes.CurrentRow.Cells["StudentName"].Value.ToString();

                // FIX QUAN TRỌNG
                DateTime parsedDate;
                if (DateTime.TryParse(dgv_classes.CurrentRow.Cells["BirthOfDate"].Value.ToString(), out parsedDate))
                {
                    dtp_BirthOfDate.Value = parsedDate;
                } else {
                    dtp_BirthOfDate.Value = DateTime.Now;
                }

                tbox_Address.Text = dgv_classes.CurrentRow.Cells["Address"].Value.ToString();
                tbox_ClassName.Text = dgv_classes.CurrentRow.Cells["ClassName"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            DataBaseDataContext db = new DataBaseDataContext();

            int studentID = int.Parse(tbox_studentID.Text);

            // CHECK TRÙNG MSSV
            if (db.Students.Any(s => s.StudentID == studentID))
            {
                MessageBox.Show("MSSV đã tồn tại!");
                return;
            }

            // Tìm class theo tên
            var cls = db.Classes
                .FirstOrDefault(c => c.ClassName == tbox_ClassName.Text.Trim());

            if (cls == null)
            {
                MessageBox.Show("Lớp không tồn tại!");
                return;
            }

            Student newStudent = new Student
            {
                StudentID = int.Parse(tbox_studentID.Text),
                StudentName = tbox_StudentName.Text,
                BirthOfDate = dtp_BirthOfDate.Value.ToString("yyyy-MM-dd"),
                Address = tbox_Address.Text,

                ClassID = cls.ClassID
            };

            db.Students.InsertOnSubmit(newStudent);
            db.SubmitChanges();

            MessageBox.Show("Thêm sinh viên thành công!");
            load_data();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            DataBaseDataContext db = new DataBaseDataContext();

            if (!int.TryParse(tbox_studentID.Text, out int studentID))
            {
                MessageBox.Show("MSSV không hợp lệ!");
                return;
            }

            Student studentToUpdate = db.Students
                .FirstOrDefault(s => s.StudentID == studentID);

            var cls = db.Classes
                        .FirstOrDefault(c => c.ClassName == tbox_ClassName.Text.Trim());

            if (studentToUpdate == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            if (cls == null)
            {
                MessageBox.Show("Lớp không tồn tại!");
                return;
            }

            studentToUpdate.ClassID = cls.ClassID;

            studentToUpdate.StudentName = tbox_StudentName.Text.Trim();
            studentToUpdate.BirthOfDate = dtp_BirthOfDate.Value.ToString("yyyy-MM-dd");
            studentToUpdate.Address = tbox_Address.Text.Trim();

            db.SubmitChanges();

            MessageBox.Show("Cập nhật thành công!");
            load_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbox_studentID.Text, out int studentID))
            {
                MessageBox.Show("MSSV không hợp lệ!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            DataBaseDataContext db = new DataBaseDataContext();

            Student studentToDelete = db.Students
                .FirstOrDefault(s => s.StudentID == studentID);

            if (studentToDelete == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            db.Students.DeleteOnSubmit(studentToDelete);
            db.SubmitChanges();

            MessageBox.Show("Xóa thành công!");
            load_data();
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

        private bool ValidateInput()
        {
            // MSSV
            if (string.IsNullOrWhiteSpace(tbox_studentID.Text))
            {
                MessageBox.Show("MSSV không được để trống!");
                return false;
            }

            if (!int.TryParse(tbox_studentID.Text, out _))
            {
                MessageBox.Show("MSSV phải là số!");
                return false;
            }

            // Tên
            if (string.IsNullOrWhiteSpace(tbox_StudentName.Text))
            {
                MessageBox.Show("Tên sinh viên không được để trống!");
                return false;
            }

            // Địa chỉ
            if (string.IsNullOrWhiteSpace(tbox_Address.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                return false;
            }

            // Ngày sinh (>= 18 tuổi)
            int age = DateTime.Now.Year - dtp_BirthOfDate.Value.Year;
            if (age < 18)
            {
                MessageBox.Show("Sinh viên phải >= 18 tuổi!");
                return false;
            }

            return true;
        }
    }
}
