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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("eo");
        }

        private void Create_Username_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Password2_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_UseOfTerms_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Create_Create_Button_Click(object sender, EventArgs e)
        {

        }

        private void Create_Back_Button_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Close();
        }

        private void CreateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count <= 0)
            {
                Application.Exit();
            }
        }
    }
}
