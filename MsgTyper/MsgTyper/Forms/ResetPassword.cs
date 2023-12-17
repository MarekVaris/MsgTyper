using MsgTyper.Models;
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

        private void ResetPassword_Load(object sender, EventArgs e)
        {

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
            if (string.IsNullOrEmpty(Reset_Username_Label.Text)) MessageBox.Show("Please enter your username.");
            else if (string.IsNullOrEmpty(Reset_Password_Label.Text)) MessageBox.Show("Please enter your password.");
            else if (string.IsNullOrEmpty(Reset_Password2_Label.Text)) MessageBox.Show("Please enter your password.");
            else
            {
                if (Reset_Password_TextBox.Text == Reset_Password2_TextBox.Text)
                {
                    Users.User[] allUsers = Users.LoadJson();
                    bool user_exist = false;

                    foreach (Users.User user in allUsers)
                    {
                        if (user.Username == Reset_Username_TextBox.Text)
                        {
                            user_exist = true;
                            break;
                        }
                    }
                    if (user_exist)
                    {
                        Users.ResetPassword(Reset_Username_TextBox.Text, Reset_Password_TextBox.Text);
                        Owner.Show();
                        this.Close();
                    }
                    else MessageBox.Show($"User: {Reset_Username_TextBox.Text} not found.");

                }
                else MessageBox.Show("Confirm that password is the same.");
            }
        }
    }
}
