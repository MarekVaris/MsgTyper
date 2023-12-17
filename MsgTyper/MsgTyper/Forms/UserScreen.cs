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
        private string V = "dwa213wadded";


        public UserScreen()
        {
            InitializeComponent();
        }

        private void UserItems()
        {
            UserDataLoad[] userdataloads = new UserDataLoad[20];

            for (int i = 0; i < userdataloads.Length; i++)
            {
                userdataloads[i] = new UserDataLoad();
                userdataloads[i].User_Name = V;
                userdataloads[i].Message_Send = V;
                /*
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                    */
                flowLayoutPanel1.Controls.Add(userdataloads[i]);
            }
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            UserItems();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MainForm main_orm = new MainForm();
            main_orm.ShowDialog(this);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count <= 0)
            {
                Application.Exit();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
