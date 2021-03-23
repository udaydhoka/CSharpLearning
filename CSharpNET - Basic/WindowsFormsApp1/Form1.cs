using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Clear();
            Form2 form2 = new Form2();
            form2.Show();
            Form3 form3 = new Form3();
            form3.Show();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lstConstructors.Items.Clear();
            lstProperties.Items.Clear();
            lstMethods.Items.Clear();

            string s = textBox1.Text;
            Type t = Type.GetType(s);
            PropertyInfo[] p = t.GetProperties();
            foreach(var x in p)
                lstProperties.Items.Add(x.PropertyType.Name +" " + x.Name);

            ConstructorInfo[] c = t.GetConstructors();
            foreach(var y in c)
                lstConstructors.Items.Add(y.ToString());

            MethodInfo[] m = t.GetMethods();
            foreach(var z in m)
                lstMethods.Items.Add(z.ReturnType.Name+" "+z.Name);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
