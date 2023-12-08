using MsgTyper.Forms;
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
using static System.Windows.Forms.DataFormats;

namespace MsgTyper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void Create_Account_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUserForm create_user = new CreateUserForm();
            this.Hide();
            create_user.ShowDialog(this);
        }
        private void Reset_password_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword reset_password = new ResetPassword();
            this.Hide();
            reset_password.ShowDialog(this);
            
        }

        private void Guest_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Username_TextBox.Text)) MessageBox.Show("Please enter your username.");
            else if (string.IsNullOrEmpty(Password_TextBox.Text)) MessageBox.Show("Please enter your password.");
            else
            {
                Debug.Write(Username_TextBox.Text);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count <= 0)
            {
                Application.Exit();
            }
        }
    }
}
