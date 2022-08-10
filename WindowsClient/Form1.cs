using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WindowsClient
{

    public partial class Form1 : Form
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetPerson_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            string jsonData = webClient.DownloadString("https://localhost:44321/api/test/getperson");
            Person person = JsonConvert.DeserializeObject<Person>(jsonData);

            labelName.Text = person.Name;
            labelAge.Text = person.Age.ToString();
        }
    }
}
