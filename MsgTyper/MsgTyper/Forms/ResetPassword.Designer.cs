namespace MsgTyper.Forms
{
    partial class ResetPassword
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
            Reset_Username_Label = new Label();
            Reset_Password_Label = new Label();
            Reset_Password2_Label = new Label();
            Reset_Username_TextBox = new TextBox();
            Reset_Password_TextBox = new TextBox();
            Reset_Password2_TextBox = new TextBox();
            Reset_Back_Button = new Button();
            Reset_ResetPassword_Button = new Button();
            SuspendLayout();
            // 
            // Reset_Username_Label
            // 
            Reset_Username_Label.AutoSize = true;
            Reset_Username_Label.Location = new Point(56, 20);
            Reset_Username_Label.Name = "Reset_Username_Label";
            Reset_Username_Label.Size = new Size(60, 15);
            Reset_Username_Label.TabIndex = 0;
            Reset_Username_Label.Text = "Username";
            // 
            // Reset_Password_Label
            // 
            Reset_Password_Label.AutoSize = true;
            Reset_Password_Label.Location = new Point(59, 59);
            Reset_Password_Label.Name = "Reset_Password_Label";
            Reset_Password_Label.Size = new Size(57, 15);
            Reset_Password_Label.TabIndex = 1;
            Reset_Password_Label.Text = "Password";
            // 
            // Reset_Password2_Label
            // 
            Reset_Password2_Label.AutoSize = true;
            Reset_Password2_Label.Location = new Point(12, 88);
            Reset_Password2_Label.Name = "Reset_Password2_Label";
            Reset_Password2_Label.Size = new Size(104, 15);
            Reset_Password2_Label.TabIndex = 2;
            Reset_Password2_Label.Text = "Confirm Password";
            // 
            // Reset_Username_TextBox
            // 
            Reset_Username_TextBox.Location = new Point(122, 17);
            Reset_Username_TextBox.Name = "Reset_Username_TextBox";
            Reset_Username_TextBox.Size = new Size(133, 23);
            Reset_Username_TextBox.TabIndex = 3;
            Reset_Username_TextBox.TextChanged += Reset_Username_TextBox_TextChanged;
            // 
            // Reset_Password_TextBox
            // 
            Reset_Password_TextBox.Location = new Point(122, 56);
            Reset_Password_TextBox.Name = "Reset_Password_TextBox";
            Reset_Password_TextBox.PasswordChar = '*';
            Reset_Password_TextBox.Size = new Size(133, 23);
            Reset_Password_TextBox.TabIndex = 4;
            Reset_Password_TextBox.TextChanged += Reset_Password_TextBox_TextChanged;
            // 
            // Reset_Password2_TextBox
            // 
            Reset_Password2_TextBox.Location = new Point(122, 85);
            Reset_Password2_TextBox.Name = "Reset_Password2_TextBox";
            Reset_Password2_TextBox.PasswordChar = '*';
            Reset_Password2_TextBox.Size = new Size(133, 23);
            Reset_Password2_TextBox.TabIndex = 5;
            Reset_Password2_TextBox.TextChanged += Reset_Password2_TextBox_TextChanged;
            // 
            // Reset_Back_Button
            // 
            Reset_Back_Button.Location = new Point(12, 126);
            Reset_Back_Button.Name = "Reset_Back_Button";
            Reset_Back_Button.Size = new Size(75, 23);
            Reset_Back_Button.TabIndex = 6;
            Reset_Back_Button.Text = "Back";
            Reset_Back_Button.UseVisualStyleBackColor = true;
            Reset_Back_Button.Click += Reset_Back_Button_Click;
            // 
            // Reset_ResetPassword_Button
            // 
            Reset_ResetPassword_Button.Location = new Point(169, 126);
            Reset_ResetPassword_Button.Name = "Reset_ResetPassword_Button";
            Reset_ResetPassword_Button.Size = new Size(103, 23);
            Reset_ResetPassword_Button.TabIndex = 7;
            Reset_ResetPassword_Button.Text = "Reset Password";
            Reset_ResetPassword_Button.UseVisualStyleBackColor = true;
            Reset_ResetPassword_Button.Click += Reset_ResetPassword_Button_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(Reset_ResetPassword_Button);
            Controls.Add(Reset_Back_Button);
            Controls.Add(Reset_Password2_TextBox);
            Controls.Add(Reset_Password_TextBox);
            Controls.Add(Reset_Username_TextBox);
            Controls.Add(Reset_Password2_Label);
            Controls.Add(Reset_Password_Label);
            Controls.Add(Reset_Username_Label);
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResetPassword";
            FormClosed += ResetPassword_FormClosed;
            Load += ResetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Reset_Username_Label;
        private Label Reset_Password_Label;
        private Label Reset_Password2_Label;
        private TextBox Reset_Username_TextBox;
        private TextBox Reset_Password_TextBox;
        private TextBox Reset_Password2_TextBox;
        private Button Reset_Back_Button;
        private Button Reset_ResetPassword_Button;
    }
}