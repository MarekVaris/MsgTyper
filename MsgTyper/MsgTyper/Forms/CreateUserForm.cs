using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using MsgTyper.Models;

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
            if (Create_UseOfTerms_CheckBox.Checked)
            {
                if (string.IsNullOrEmpty(Create_Username_TextBox.Text)) MessageBox.Show("Please enter your username.");
                else if (string.IsNullOrEmpty(Create_Password_TextBox.Text)) MessageBox.Show("Please enter your password.");
                else if (string.IsNullOrEmpty(Create_Password2_TextBox.Text)) MessageBox.Show("Please confirm your password.");
                else
                {
                    if (Create_Password_TextBox.Text == Create_Password2_TextBox.Text)
                    {
                        Users.CreateNormal(Create_Username_TextBox.Text, Create_Password_TextBox.Text);
                        MainForm mainForm = new MainForm();
                        mainForm.Show();

                        this.Close();
                    }
                    else MessageBox.Show("Confirm that password the same.");
                }
            }
            else
            {
                MessageBox.Show("Please check your use of terms.");
            }
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
