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

        }
        private void Reset_password_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Guest_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string username_input = Username_TextBox.Text;
            string password_input = Password_TextBox.Text;



            if (username_input == "" || password_input == "")
            {
                Debug.WriteLine("Wprowadz dane");
            }
            else
            {
                Debug.WriteLine(username_input);
            }

        }

    }
}
