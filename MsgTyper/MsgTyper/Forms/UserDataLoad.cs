using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MsgTyper.Forms
{
    public partial class UserDataLoad : UserControl
    {
        public UserDataLoad()
        {
            InitializeComponent();
        }

        private string _name;
        private string _message;

        [Category("custom Props")]
        public string User_Name
        {
            get { return _name; }
            set { _name = value; UserName.Text = value; }
        }

        [Category("custom Props")]
        public string Message_Send
        {
            get { return _message; }
            set { _message = value; MessageSend.Text = value; }
        }
        private void UserDataLoad_Load(object sender, EventArgs e)
        {

        }
    }
}
