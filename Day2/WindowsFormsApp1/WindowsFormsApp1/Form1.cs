using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://localhost:6565/");
        }
        HttpClient client = new HttpClient();
        private void btn_students_Click(object sender, EventArgs e)
        {
           
            HttpResponseMessage message = client.GetAsync("api/students").Result;

            if (message.IsSuccessStatusCode)
            {
                List<Student> students = message.Content.ReadAsAsync<List<Student>>().Result;
                gv_stds.DataSource = students;

            }


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student std = new Student()
            {
                fullName = txt_name.Text,
                address = txt_address.Text
            };

            HttpResponseMessage mess = client.PostAsJsonAsync("api/students", std).Result;

            if (mess.IsSuccessStatusCode)
            {
                HttpResponseMessage message = client.GetAsync("api/students").Result;
                if (message.IsSuccessStatusCode)
                {
                    List<Student> students = message.Content.ReadAsAsync<List<Student>>().Result;
                    gv_stds.DataSource = students;
                }
            }

        }
    }
}
