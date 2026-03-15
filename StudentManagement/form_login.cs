using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace StudentManagement
{
    public partial class form_login : Form
    {

        public form_login()
        {
            InitializeComponent();
        }

        // Method to set rounded corners for a control
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

        // Event handler for form load
        private void form_login_Load(object sender, EventArgs e)
        {
            SetRoundedRegion(pn_login, 40);
            SetRoundedRegion(btn_login, 20);
        }

        private void lb_login_Click(object sender, EventArgs e)
        {

        }


        // Event handler for login system
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tbox_username.Text;
            string password = tbox_password.Text;

            DataBaseDataContext db = new DataBaseDataContext();
            var account = db.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
            if (account != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                form_dashboard mainForm = new form_dashboard();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
        }

        private void tbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pn_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
