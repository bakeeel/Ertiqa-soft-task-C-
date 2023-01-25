using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ertiqa_soft
{

    public partial class LoginUserControl : UserControl
    {
        private static LoginUserControl _instance;
        public LoginUserControl()
        {
            InitializeComponent();
        }

        public static LoginUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginUserControl();
                return _instance;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
            

        private void LoginUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
