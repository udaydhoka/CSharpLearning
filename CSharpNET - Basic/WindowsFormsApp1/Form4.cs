using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader = new StreamReader(@"C:\Mine\Dev\CSharp\WindowsFormsApp1\data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        
        // below method will freeze the UI

        //private void Button1_Click(object sender, EventArgs e)
        //{        
        //    label1.Text = "Processing file, please wait...";
        //    int count = CountCharacters();
        //    label1.Text = count.ToString() + "  chars in our file";

        //}

        ////mod 101
        
        ////here we're using async and await, which will not freeze the UI
        //private async void Button1_Click(object sender, EventArgs e)
        //{
        //    Task<int> task = new Task<int>(CountCharacters);
        //    task.Start();
        //    label1.Text = "Processing file, please wait...";
        //    int count = await task;
        //    label1.Text = count.ToString() + "  chars in our file";

        //}

        //mod 102
        // using threads 
        private  void Button1_Click(object sender, EventArgs e)
        {
            //this code works fine, but while processing UI will be not changable

            //int count = 0;
            //Thread t = new Thread(() => {count = CountCharacters();});
            //t.Start();
            //label1.Text = "Processing file, please wait...";
            //t.Join();
            //label1.Text = count.ToString() + "  chars in our file";

            int count = 0;
            Thread t = new Thread(() => 
            {
                count = CountCharacters();
                Action action = () => label1.Text = count.ToString() + "  chars in our file";
                this.BeginInvoke(action);
            });
            
            t.Start();            
            label1.Text = "Processing file, please wait...";            
           

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
