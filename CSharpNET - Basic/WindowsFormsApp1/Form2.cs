using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            // Create another THREAD to offload the work of
            // executing the time consuming method to it.
            // As a result the UI thread, is free to execute the
            // rest of the code and our application is more responsive
            Thread workerThread = new Thread(DoTimeConsumingWork);
            workerThread.Start();

            //commenting it to create a separate thread
            //DoTimeConsumingWork();

            button2.Enabled = true;
            button1.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            // Make the thread sleep, to introduce artifical latency
            Thread.Sleep(5000);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
