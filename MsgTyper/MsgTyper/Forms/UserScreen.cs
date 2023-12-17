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
        public UserScreen()
        {
            InitializeComponent();
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {

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


    }
}
