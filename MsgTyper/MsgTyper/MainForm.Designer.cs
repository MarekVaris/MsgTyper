namespace MsgTyper
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
            Username_TextBox.Location = new Point(78, 12);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.Size = new Size(194, 23);
            Username_TextBox.TabIndex = 0;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.ImeMode = ImeMode.NoControl;
            Username_Label.Location = new Point(9, 15);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(63, 15);
            Username_Label.TabIndex = 1;
            Username_Label.Text = "Username:";
            Username_Label.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Password:";
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(78, 41);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.Size = new Size(194, 23);
            Password_TextBox.TabIndex = 2;
            // 
            // Login_Button
            // 
            Login_Button.ImeMode = ImeMode.NoControl;
            Login_Button.Location = new Point(197, 126);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(75, 23);
            Login_Button.TabIndex = 4;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += button1_Click;
            // 
            // Create_Account_LinkLabel
            // 
            Create_Account_LinkLabel.AutoSize = true;
            Create_Account_LinkLabel.ImeMode = ImeMode.NoControl;
            Create_Account_LinkLabel.Location = new Point(12, 76);
            Create_Account_LinkLabel.Name = "Create_Account_LinkLabel";
            Create_Account_LinkLabel.Size = new Size(89, 15);
            Create_Account_LinkLabel.TabIndex = 5;
            Create_Account_LinkLabel.TabStop = true;
            Create_Account_LinkLabel.Text = "Create Account";
            Create_Account_LinkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Guest_LinkLabel
            // 
            Guest_LinkLabel.AutoSize = true;
            Guest_LinkLabel.ImeMode = ImeMode.NoControl;
            Guest_LinkLabel.Location = new Point(12, 101);
            Guest_LinkLabel.Name = "Guest_LinkLabel";
            Guest_LinkLabel.Size = new Size(83, 15);
            Guest_LinkLabel.TabIndex = 6;
            Guest_LinkLabel.TabStop = true;
            Guest_LinkLabel.Text = "Login as guest";
            // 
            // Reset_password_LinkLabel
            // 
            Reset_password_LinkLabel.AutoSize = true;
            Reset_password_LinkLabel.ImeMode = ImeMode.NoControl;
            Reset_password_LinkLabel.Location = new Point(184, 76);
            Reset_password_LinkLabel.Name = "Reset_password_LinkLabel";
            Reset_password_LinkLabel.Size = new Size(88, 15);
            Reset_password_LinkLabel.TabIndex = 7;
            Reset_password_LinkLabel.TabStop = true;
            Reset_password_LinkLabel.Text = "Reset password";
            // 
            // Quit_Button
            // 
            Quit_Button.ImeMode = ImeMode.NoControl;
            Quit_Button.Location = new Point(9, 126);
            Quit_Button.Name = "Quit_Button";
            Quit_Button.Size = new Size(75, 23);
            Quit_Button.TabIndex = 8;
            Quit_Button.Text = "Quit";
            Quit_Button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
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