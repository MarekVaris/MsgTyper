namespace MsgTyper.Forms
{
    partial class CreateUserForm
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
            Create_Username_Label = new Label();
            Create_Password_Label = new Label();
            Create_Password2_Label = new Label();
            Create_Username_TextBox = new TextBox();
            Create_Password_TextBox = new TextBox();
            Create_Password2_TextBox = new TextBox();
            Create_UseOfTerms_CheckBox = new CheckBox();
            Create_Create_Button = new Button();
            Create_Back_Button = new Button();
            SuspendLayout();
            // 
            // Create_Username_Label
            // 
            Create_Username_Label.AutoSize = true;
            Create_Username_Label.Location = new Point(93, 31);
            Create_Username_Label.Name = "Create_Username_Label";
            Create_Username_Label.Size = new Size(62, 15);
            Create_Username_Label.TabIndex = 0;
            Create_Username_Label.Text = "UserName";
            // 
            // Create_Password_Label
            // 
            Create_Password_Label.AutoSize = true;
            Create_Password_Label.Location = new Point(98, 73);
            Create_Password_Label.Name = "Create_Password_Label";
            Create_Password_Label.Size = new Size(57, 15);
            Create_Password_Label.TabIndex = 1;
            Create_Password_Label.Text = "Password";
            // 
            // Create_Password2_Label
            // 
            Create_Password2_Label.AutoSize = true;
            Create_Password2_Label.Location = new Point(51, 107);
            Create_Password2_Label.Name = "Create_Password2_Label";
            Create_Password2_Label.Size = new Size(104, 15);
            Create_Password2_Label.TabIndex = 2;
            Create_Password2_Label.Text = "Confirm Password";
            // 
            // Create_Username_TextBox
            // 
            Create_Username_TextBox.Location = new Point(177, 28);
            Create_Username_TextBox.Name = "Create_Username_TextBox";
            Create_Username_TextBox.Size = new Size(143, 23);
            Create_Username_TextBox.TabIndex = 3;
            Create_Username_TextBox.TextChanged += Create_Username_TextBox_TextChanged;
            // 
            // Create_Password_TextBox
            // 
            Create_Password_TextBox.Location = new Point(177, 70);
            Create_Password_TextBox.Name = "Create_Password_TextBox";
            Create_Password_TextBox.PasswordChar = '*';
            Create_Password_TextBox.Size = new Size(143, 23);
            Create_Password_TextBox.TabIndex = 4;
            Create_Password_TextBox.TextChanged += Create_Password_TextBox_TextChanged;
            // 
            // Create_Password2_TextBox
            // 
            Create_Password2_TextBox.Location = new Point(177, 104);
            Create_Password2_TextBox.Name = "Create_Password2_TextBox";
            Create_Password2_TextBox.PasswordChar = '*';
            Create_Password2_TextBox.Size = new Size(143, 23);
            Create_Password2_TextBox.TabIndex = 5;
            Create_Password2_TextBox.TextChanged += Create_Password2_TextBox_TextChanged;
            // 
            // Create_UseOfTerms_CheckBox
            // 
            Create_UseOfTerms_CheckBox.AutoSize = true;
            Create_UseOfTerms_CheckBox.Location = new Point(27, 143);
            Create_UseOfTerms_CheckBox.Name = "Create_UseOfTerms_CheckBox";
            Create_UseOfTerms_CheckBox.Size = new Size(205, 19);
            Create_UseOfTerms_CheckBox.TabIndex = 6;
            Create_UseOfTerms_CheckBox.Text = "Do you agree witch use of terms...";
            Create_UseOfTerms_CheckBox.UseVisualStyleBackColor = true;
            Create_UseOfTerms_CheckBox.CheckedChanged += Create_UseOfTerms_CheckBox_CheckedChanged;
            // 
            // Create_Create_Button
            // 
            Create_Create_Button.Location = new Point(271, 178);
            Create_Create_Button.Name = "Create_Create_Button";
            Create_Create_Button.Size = new Size(101, 23);
            Create_Create_Button.TabIndex = 7;
            Create_Create_Button.Text = "Create Accout";
            Create_Create_Button.UseVisualStyleBackColor = true;
            Create_Create_Button.Click += Create_Create_Button_Click;
            // 
            // Create_Back_Button
            // 
            Create_Back_Button.Location = new Point(12, 178);
            Create_Back_Button.Name = "Create_Back_Button";
            Create_Back_Button.Size = new Size(75, 23);
            Create_Back_Button.TabIndex = 8;
            Create_Back_Button.Text = "Back";
            Create_Back_Button.UseVisualStyleBackColor = true;
            Create_Back_Button.Click += Create_Back_Button_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(Create_Back_Button);
            Controls.Add(Create_Create_Button);
            Controls.Add(Create_UseOfTerms_CheckBox);
            Controls.Add(Create_Password2_TextBox);
            Controls.Add(Create_Password_TextBox);
            Controls.Add(Create_Username_TextBox);
            Controls.Add(Create_Password2_Label);
            Controls.Add(Create_Password_Label);
            Controls.Add(Create_Username_Label);
            Name = "CreateUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateUserForm";
            FormClosed += CreateUserForm_FormClosed;
            Load += CreateUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Create_Username_Label;
        private Label Create_Password_Label;
        private Label Create_Password2_Label;
        private TextBox Create_Username_TextBox;
        private TextBox Create_Password_TextBox;
        private TextBox Create_Password2_TextBox;
        private CheckBox Create_UseOfTerms_CheckBox;
        private Button Create_Create_Button;
        private Button Create_Back_Button;
    }
}