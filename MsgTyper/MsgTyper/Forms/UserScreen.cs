using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MsgTyper.Models;

namespace MsgTyper.Forms
{
    public partial class UserScreen : Form
    {
        public string login;
        // Constructor for login information
        public UserScreen(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        // Method to load user items
        private void UserItems()
        {
            // Load all messages from JSON
            _Message.Message[] allUsers = _Message.LoadJsonMess();


            // Iterate through each message
            foreach (_Message.Message user in allUsers)
            {
                UserDataLoad userdataloads = new UserDataLoad();
                if (user.Username1 == login)
                {
                    // Set user name and message for the receiver
                    userdataloads.User_Name = "To: " + user.Username2;
                    userdataloads.Message_Send = user.Mess;
                    flowLayoutPanel1.Controls.Add(userdataloads);
                }
                else if (user.Username2 == login) 
                {
                    // Set user name and message for the receiver
                    userdataloads.User_Name = "From: "+ user.Username1;
                    userdataloads.Message_Send = user.Mess;
                    flowLayoutPanel1.Controls.Add(userdataloads);
                }
                //If empty skips
                else { }

            }
        }

        // Event handler for the form load event
        private void UserScreen_Load(object sender, EventArgs e)
        {
            UserItems();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Event handler for the Quit button click event
        private void Quit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the Log Out button click event
        private void Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MainForm main_orm = new MainForm();
            main_orm.ShowDialog(this);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Event handler for the form closed event
        private void UserScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner.Visible == false)
            {
                Application.Exit();
            }
        }
    }
}
