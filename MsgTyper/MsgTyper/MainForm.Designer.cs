﻿namespace MsgTyper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username_TextBox = new TextBox();
            Username_Label = new Label();
            label1 = new Label();
            Password_TextBox = new TextBox();
            Login_Button = new Button();
            Create_Account_LinkLabel = new LinkLabel();
            Guest_LinkLabel = new LinkLabel();
            Reset_password_LinkLabel = new LinkLabel();
            Quit_Button = new Button();
            SuspendLayout();
            // 
            // Username_TextBox
            // 
            Username_TextBox.Location = new Point(145, 26);
            Username_TextBox.Margin = new Padding(6);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.Size = new Size(357, 39);
            Username_TextBox.TabIndex = 0;
            Username_TextBox.TextChanged += Username_TextBox_TextChanged_1;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.ImeMode = ImeMode.NoControl;
            Username_Label.Location = new Point(17, 32);
            Username_Label.Margin = new Padding(6, 0, 6, 0);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(126, 32);
            Username_Label.TabIndex = 1;
            Username_Label.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(22, 94);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 3;
            label1.Text = "Password:";
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(145, 87);
            Password_TextBox.Margin = new Padding(6);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PasswordChar = '*';
            Password_TextBox.Size = new Size(357, 39);
            Password_TextBox.TabIndex = 2;
            Password_TextBox.TextChanged += Password_TextBox_TextChanged;
            // 
            // Login_Button
            // 
            Login_Button.ImeMode = ImeMode.NoControl;
            Login_Button.Location = new Point(366, 269);
            Login_Button.Margin = new Padding(6);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(139, 49);
            Login_Button.TabIndex = 4;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // Create_Account_LinkLabel
            // 
            Create_Account_LinkLabel.AutoSize = true;
            Create_Account_LinkLabel.ImeMode = ImeMode.NoControl;
            Create_Account_LinkLabel.Location = new Point(22, 162);
            Create_Account_LinkLabel.Margin = new Padding(6, 0, 6, 0);
            Create_Account_LinkLabel.Name = "Create_Account_LinkLabel";
            Create_Account_LinkLabel.Size = new Size(177, 32);
            Create_Account_LinkLabel.TabIndex = 5;
            Create_Account_LinkLabel.TabStop = true;
            Create_Account_LinkLabel.Text = "Create Account";
            Create_Account_LinkLabel.LinkClicked += Create_Account_LinkLabel_LinkClicked;
            // 
            // Guest_LinkLabel
            // 
            Guest_LinkLabel.AutoSize = true;
            Guest_LinkLabel.ImeMode = ImeMode.NoControl;
            Guest_LinkLabel.Location = new Point(22, 215);
            Guest_LinkLabel.Margin = new Padding(6, 0, 6, 0);
            Guest_LinkLabel.Name = "Guest_LinkLabel";
            Guest_LinkLabel.Size = new Size(168, 32);
            Guest_LinkLabel.TabIndex = 6;
            Guest_LinkLabel.TabStop = true;
            Guest_LinkLabel.Text = "Login as guest";
            Guest_LinkLabel.LinkClicked += Guest_LinkLabel_LinkClicked;
            // 
            // Reset_password_LinkLabel
            // 
            Reset_password_LinkLabel.AutoSize = true;
            Reset_password_LinkLabel.ImeMode = ImeMode.NoControl;
            Reset_password_LinkLabel.Location = new Point(342, 162);
            Reset_password_LinkLabel.Margin = new Padding(6, 0, 6, 0);
            Reset_password_LinkLabel.Name = "Reset_password_LinkLabel";
            Reset_password_LinkLabel.Size = new Size(177, 32);
            Reset_password_LinkLabel.TabIndex = 7;
            Reset_password_LinkLabel.TabStop = true;
            Reset_password_LinkLabel.Text = "Reset password";
            Reset_password_LinkLabel.LinkClicked += Reset_password_LinkLabel_LinkClicked;
            // 
            // Quit_Button
            // 
            Quit_Button.ImeMode = ImeMode.NoControl;
            Quit_Button.Location = new Point(17, 269);
            Quit_Button.Margin = new Padding(6);
            Quit_Button.Name = "Quit_Button";
            Quit_Button.Size = new Size(139, 49);
            Quit_Button.TabIndex = 8;
            Quit_Button.Text = "Quit";
            Quit_Button.UseVisualStyleBackColor = true;
            Quit_Button.Click += Quit_Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 343);
            Controls.Add(Quit_Button);
            Controls.Add(Reset_password_LinkLabel);
            Controls.Add(Guest_LinkLabel);
            Controls.Add(Create_Account_LinkLabel);
            Controls.Add(Login_Button);
            Controls.Add(label1);
            Controls.Add(Password_TextBox);
            Controls.Add(Username_Label);
            Controls.Add(Username_TextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MinimizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username_TextBox;
        private Label Username_Label;
        private Label label1;
        private TextBox Password_TextBox;
        private Button Login_Button;
        private LinkLabel Create_Account_LinkLabel;
        private LinkLabel Guest_LinkLabel;
        private LinkLabel Reset_password_LinkLabel;
        private Button Quit_Button;
    }
}