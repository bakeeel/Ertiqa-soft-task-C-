using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ertiqa_soft
{
    public partial class HomeForm : Form
    {

       

        private DAL.LoginClass login = new DAL.LoginClass();
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (!panel1.Controls.Contains(LoginUserControl.Instance))
            {
                panel1.Controls.Add(LoginUserControl.Instance);
                LoginUserControl.Instance.Dock = DockStyle.Fill;
                LoginUserControl.Instance.BringToFront();

            }
            else
            {
                LoginUserControl.Instance.BringToFront();

            }*/

            panel1.Visible = true;

            button1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
         


             DataTable dt = new DataTable();
             dt = login.LOGIN(UserTextBox.Text, PassTextBox.Text);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                LoadForm l = new LoadForm();
                l.Closed += (s, args) => this.Close();
                l.ShowDialog();
                //Form someForm = (Form)this.Parent;
                //someForm.Close();
                //((Form)this.TopLevelControl).Close();

            }
            else
            {
                MessageBox.Show(" _^_ Sure from Your acount _^_ ");
                UserTextBox.Clear();
                PassTextBox.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void PassTextBox_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void UserTextBox_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void UserTextBox_Click(object sender, EventArgs e)
        {
            UserTextBox.BorderStyle = BorderStyle.Fixed3D;
            
        }

        private void PassTextBox_CursorChanged(object sender, EventArgs e)
        {

        }

        private void PassTextBox_Click(object sender, EventArgs e)
        {

        }

        private void PassTextBox_Leave(object sender, EventArgs e)
        {
            PassTextBox.BorderStyle = BorderStyle.None;
        }

        private void PassTextBox_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void PassTextBox_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }

        private void PassTextBox_AcceptsTabChanged(object sender, EventArgs e)
        {

        }

        private void PassTextBox_Enter(object sender, EventArgs e)
        {
            PassTextBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void UserTextBox_Enter(object sender, EventArgs e)
        {
            UserTextBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void UserTextBox_Leave(object sender, EventArgs e)
        {
            UserTextBox.BorderStyle = BorderStyle.None;
        }
    }
    
}
