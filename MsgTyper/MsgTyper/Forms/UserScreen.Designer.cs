namespace MsgTyper.Forms
{
    partial class UserScreen
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
            panel1 = new Panel();
            Quit_Button = new Button();
            Log_Out = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 360);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Quit_Button
            // 
            Quit_Button.ImeMode = ImeMode.NoControl;
            Quit_Button.Location = new Point(12, 369);
            Quit_Button.Name = "Quit_Button";
            Quit_Button.Size = new Size(75, 23);
            Quit_Button.TabIndex = 8;
            Quit_Button.Text = "Quit";
            Quit_Button.UseVisualStyleBackColor = true;
            Quit_Button.Click += Quit_Button_Click;
            // 
            // Log_Out
            // 
            Log_Out.Location = new Point(406, 369);
            Log_Out.Name = "Log_Out";
            Log_Out.Size = new Size(75, 23);
            Log_Out.TabIndex = 2;
            Log_Out.Text = "Log Out";
            Log_Out.UseVisualStyleBackColor = true;
            Log_Out.Click += Log_Out_Click;
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 404);
            Controls.Add(Log_Out);
            Controls.Add(Quit_Button);
            Controls.Add(panel1);
            Name = "UserScreen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UserScreen";
            Load += UserScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Quit_Button;
        private Button Log_Out;
    }
}