using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static MsgTyper.Models.Users;

namespace MsgTyper.Models
{

    public class _Message
    {
        public class Message
        {

            // Encapsulation: private fields
            private string username1;
            private string username2;
            private string message;

            private DateTime dateTime = DateTime.Now;
            public string Created_in { get; set; }

            // Encapsulation: properties to access fields
            public string Username1
            {
                get { return username1; }
                set { username1 = value; }
            }

            public string Username2
            {
                get { return username2; }
                set { username2 = value; }
            }

            public string Mess
            {
                get { return message; }
                set { message = value; }
            }

            // Inheritance
            public Message(string username1, string username2, string message)
            {
                Username1 = username1;
                Username2 = username2;
                Mess = message;
                Created_in = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }

        }

        //Load messages from JSON file
        public static Message[] LoadJsonMess()
        {
            try
            {
                string json = File.ReadAllText("Message.json");
                Message[] mess = JsonConvert.DeserializeObject<Message[]>(json);
                return mess;
            }
            catch
            {
                Message[] send =
                {
                        new Message("admin", "adadad", "dwadwadad awdad daw a dawd wd")
                };

                SaveMessJson(send);
                return send;
            }
        }

        //Save messages to the JSON file
        public static void SaveMessJson(Message[] users_list)
        {
            string default_json = JsonConvert.SerializeObject(users_list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("Message.json", default_json);
        }

    }
}
