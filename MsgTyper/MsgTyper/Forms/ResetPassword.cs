using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgTyper.Forms
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }


        private void Reset_Username_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Password2_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Back_Button_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        private void Reset_ResetPassword_Button_Click(object sender, EventArgs e)
        {

        }

        private void ResetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ( Owner.Visible == false)
            {
                Application.Exit();
            }
        }
    }
}
