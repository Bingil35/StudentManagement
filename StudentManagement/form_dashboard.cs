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
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class form_dashboard : Form
    {
        public form_dashboard()
        {
            InitializeComponent();
            Load_Control(new StudentManagementControl());
        }

        public void Load_Control(UserControl uc)
        {
            pn_Main.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pn_Main.Controls.Add(uc);
        }


        private void tbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_classes_Click(object sender, EventArgs e)
        {
            Load_Control(new ClassesManagementControl());
        }

        private void btn_students_Click(object sender, EventArgs e)
        {
            Load_Control(new StudentManagementControl());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
