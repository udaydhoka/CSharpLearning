using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Queuedemo : System.Web.UI.Page
    {
        /* my code
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["tokens"] == null)
            {                
                Queue<int> tokens = new Queue<int>();                
                Session["tokens"] = tokens;
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (((Queue<int>)Session["tokens"]).Count != 0)
            {
                Queue<int> temp = (Queue<int>)Session["tokens"];
                int num = temp.Dequeue();
                txtbox1.Text = num.ToString();
                counterbox.Text = "Token number" + num + ": Please go to Counter 1";
                listtokens.Items.Remove(num.ToString());
                currentStatus.Text = "There are currently " + temp.Count + " customers in the queue";
                Session["tokens"] = temp;

            }
            else
            {
                counterbox.Text = "Currently no Customers are waiting in the queue";
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            if (((Queue<int>)Session["tokens"]).Count != 0)
            {
                Queue<int> temp = (Queue<int>)Session["tokens"];
                int num = temp.Dequeue();
                txtbox2.Text = num.ToString();
                counterbox.Text = "Token number" + num + ": Please go to Counter 2";
                listtokens.Items.Remove(num.ToString());
                currentStatus.Text = "There are currently " + temp.Count + " customers in the queue";
                Session["tokens"] = temp;
            }
            else
            {
                counterbox.Text = "Currently no Customers are waiting in the queue";
            }
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            if (((Queue<int>)Session["tokens"]).Count != 0)
            {
                Queue<int> temp = (Queue<int>)Session["tokens"];
                int num = temp.Dequeue();
                txtbox3.Text = num.ToString();
                counterbox.Text = "Token number" + num + ": Please go to Counter 3";
                listtokens.Items.Remove(num.ToString());
                currentStatus.Text = "There are currently " + temp.Count + " customers in the queue";
                Session["tokens"] = temp;
            }
            else
            {
                counterbox.Text = "Currently no Customers are waiting in the queue";
            }
        }      

        protected void btnprinttoken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenPrint = (Queue<int>)Session["tokens"];
            
            if(Session["tokenGeneration"]==null)
            {
                Session["tokenGeneration"] = 0;
                int token = (int)Session["tokenGeneration"] + 1;                
                tokenPrint.Enqueue(token);
                currentStatus.Text = "There are currently " + tokenPrint.Count + " customers in the queue";
                listtokens.Items.Add(token.ToString());                 
                Session["tokenGeneration"] = token;
            }
            else
            {
                int token = (int)Session["tokenGeneration"] + 1;                
                tokenPrint.Enqueue(token);
                currentStatus.Text = "There are currently " + tokenPrint.Count + " customers in the queue";
                listtokens.Items.Add(token.ToString());
                Session["tokenGeneration"] = token;
            }
            

        }
        */

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }
        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are " + tokenQueue.Count.ToString() + " Customers before you in the queue";

            if (Session["lastTokenNumberIssued"] == null)
            {
                Session["lastTokenNumberIssued"] = 0;
            }

            int nextTokenNumberTobeIssued = (int)Session["lastTokenNumberIssued"] + 1;
            Session["lastTokenNumberIssued"] = nextTokenNumberTobeIssued;
            tokenQueue.Enqueue(nextTokenNumberTobeIssued);

            AddTOkensToListBox(tokenQueue);
        }

        private void AddTOkensToListBox(Queue<int> tokenQueue)
        {
            listTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        private void ServeNextCustomer(TextBox textbox, int counterNumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count == 0)
            {
                textbox.Text = "No Customers in the queue";
            }
            else
            {
                int tokenNuberToBeServed = tokenQueue.Dequeue();
                textbox.Text = tokenNuberToBeServed.ToString();
                txtDisplay.Text = "Token Number " + tokenNuberToBeServed.ToString() + " Please go to Counter " + counterNumber.ToString();
                AddTOkensToListBox(tokenQueue);
            }
        }
        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(txtCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(txtCounter3, 3);
        }

       
    }
}