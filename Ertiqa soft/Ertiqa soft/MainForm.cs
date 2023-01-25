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
    public partial class MainForm : Form
    {
        public bool ShowInTaskbar { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
            */
            this.Close();
            //Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ShowInTaskBarEx()
        {
            Form myForm = new MainForm();
            myForm.Text = "My Form";
            myForm.SetBounds(10, 10, 200, 200);
            myForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            myForm.MinimizeBox = false;
            myForm.MaximizeBox = false;
            // Do not allow form to be displayed in taskbar.
            myForm.ShowInTaskbar = false;
           myForm.ShowDialog();
        }
    }
}
