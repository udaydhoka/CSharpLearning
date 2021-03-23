using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            Button button1 = new Button();
            button1.Text = "Click Me";
            //usual way
            button1.Click += Button1_Click;

            //with args
            button1.Click += delegate (object senders, EventArgs er)
            {
                MessageBox.Show("Just Clicked");
            };

            //without args, as we are not using them in implementation
            button1.Click += delegate 
            {
                MessageBox.Show("Just Clicked");
            };

            //using lamda
            button1.Click += (eventSender, eventArgs) =>
            {
                MessageBox.Show("Just Clicked");
            };

            //or 
            button1.Click += (Object eventSender,EventArgs eventArgs) =>
            {
                MessageBox.Show("Just Clicked");
            };

            //or
            //belows throws error, as we cant omit params in the lamda expressions
            //button1.Click += () =>
            //{
            //    MessageBox.Show("Just Clicked");
            //};


            this.Controls.Add(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just Clicked");
        }
    }
}
