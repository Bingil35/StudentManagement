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
    public partial class form_managementClasses : Form
    {
        public form_managementClasses()
        {
            InitializeComponent();
        }

        private void form_managementClasses_Load(object sender, EventArgs e)
        {
            dgv_classes.Columns.Add("classID", "Mã lớp");
            dgv_classes.Columns.Add("className", "Tên lớp");
            dgv_classes.Columns.Add("department", "Ngành");
            dgv_classes.Columns.Add("course", "Khóa học");
            dgv_classes.Columns.Add("students", "Số sinh viên");
        }
    }
}
