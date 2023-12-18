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

        //Private fields user data
        private string _name;
        private string _message;

        //Custom property for accessing and setting the user's name
        [Category("custom Props")]
        public string User_Name
        {
            get { return _name; }
            set { _name = value; UserName.Text = value; }
        }

        //Custom property for accessing and setting the message sent by the user
        [Category("custom Props")]
        public string Message_Send
        {
            get { return _message; }
            set { _message = value; MessageSend.Text = value; }
        }
        //Event handler for the UserControl's load event
        private void UserDataLoad_Load(object sender, EventArgs e)
        {

        }
    }
}
