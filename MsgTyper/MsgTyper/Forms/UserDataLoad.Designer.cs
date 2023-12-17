namespace MsgTyper.Forms
{
    partial class UserDataLoad
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            UserName = new Label();
            MessageSend = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(UserName);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 39);
            panel1.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.AutoEllipsis = true;
            UserName.FlatStyle = FlatStyle.Flat;
            UserName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.Location = new Point(0, 0);
            UserName.Name = "UserName";
            UserName.Size = new Size(498, 39);
            UserName.TabIndex = 0;
            UserName.Text = "label1";
            // 
            // MessageSend
            // 
            MessageSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MessageSend.Location = new Point(0, 39);
            MessageSend.Name = "MessageSend";
            MessageSend.Size = new Size(498, 62);
            MessageSend.TabIndex = 1;
            MessageSend.Text = "label2";
            // 
            // UserDataLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MessageSend);
            Controls.Add(panel1);
            Name = "UserDataLoad";
            Size = new Size(498, 101);
            Load += UserDataLoad_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label UserName;
        private Label MessageSend;
    }
}
