using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetTitle(char gender)
        {
            string title = "";//declar + init
            if (gender == 'M')
            {
                title = "Mr.";
            }
            if (gender == 'F')
            {
                title = "Ms.";
            }
            return title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;

            string lastName = textBox2.Text;
            int age = Convert.ToInt32(numericUpDown1.Value);

            char gender = ' ';//declaration
            if(radioButton1.Checked)
            {
                gender = 'M';//init
            }
            if(radioButton2.Checked)
            {
                gender = 'F';//init
            }


            string greetings = "";
            int hour = DateTime.Now.Hour;
            if(hour>17||hour<8)
            {
                greetings = "Good Evening";
            }
            else
            {
                greetings = "Good Day";
            }
            string title = GetTitle(gender);
            string greetingMessage = greetings + "! " + title  + " " + lastName + ", Age " + age;

            MessageBox.Show(greetingMessage);
            
        }
    }
}
