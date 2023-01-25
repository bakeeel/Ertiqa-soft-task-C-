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
    public partial class LoadForm : Form
    {
        
        public LoadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(!LoadForm)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
               
                progressBar1.Value += 5;
                progressBar1.BackColor = Color.FromArgb(90, 95, 171);


                label2.Text = progressBar1.Value.ToString();

                if (label2.Text.Length > 1)
                {
                    label2.Font = new Font("Tahoma", 10);
                    label2.Location = new Point(1410, 43);
                }
            }
            else
            { 
                timer1.Stop();
                this.Hide();
                var m = new MainForm();
                m.Closed += (s, args) => this.Close();
                m.ShowDialog();
                
            }


        }
        
        private void LoadForm_Load(object sender, EventArgs e)
        {

            

            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
