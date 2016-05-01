using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JerseyShopping
{
    public partial class Catalog : System.Web.UI.Page
    {
        List<Jersey> js= new List<Jersey>();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty1.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("1.jpg", Convert.ToInt32(qty1.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("1.jpg", Convert.ToInt32(qty1.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button1.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty2.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("1.jpg", Convert.ToInt32(qty2.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("2.jpg", Convert.ToInt32(qty2.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button2.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty3.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("3.jpg", Convert.ToInt32(qty3.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("3.jpg", Convert.ToInt32(qty3.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button3.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty4.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("4.jpg", Convert.ToInt32(qty4.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("4.jpg", Convert.ToInt32(qty4.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button4.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty5.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("5.jpg", Convert.ToInt32(qty5.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("5.jpg", Convert.ToInt32(qty5.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button5.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty6.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("6.jpg", Convert.ToInt32(qty6.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("6.jpg", Convert.ToInt32(qty6.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button6.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty7.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("7.jpg", Convert.ToInt32(qty7.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("7.jpg", Convert.ToInt32(qty7.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button7.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty8.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("8.jpg", Convert.ToInt32(qty8.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("8.jpg", Convert.ToInt32(qty8.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button8.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button9_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty9.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("13.jpg", Convert.ToInt32(qty9.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("13.jpg", Convert.ToInt32(qty9.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button9.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button10_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty10.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("10.jpg", Convert.ToInt32(qty10.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("10.jpg", Convert.ToInt32(qty10.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button10.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button11_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty11.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("11.jpg", Convert.ToInt32(qty11.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("11.jpg", Convert.ToInt32(qty11.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button11.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void button12_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(qty12.Text) > 0)
            {

                if (Session["jersey"] != null)
                {
                    js = (List<Jersey>)Session["jersey"];
                    js.Add(new Jersey("12.jpg", Convert.ToInt32(qty12.Text)));
                    Session["jersey"] = js;
                }
                else
                {
                    js.Add(new Jersey("12.jpg", Convert.ToInt32(qty12.Text)));
                    Session["jersey"] = js;
                }
                MessageBox.Show(this, js.Count.ToString());
                button12.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show(this, "Increase the Quantity");
            }
        }

        protected void Checkout_Click(object sender, EventArgs e)
        {

           
                

                MessageBox.Show(this, Session["jersey"].ToString());
                button1.BackColor = System.Drawing.Color.Green;
            
            
            Response.Redirect("~/Confirmation.aspx");
        }
    }
    public static class MessageBox
    {
        public static void Show(this Page Page, String Message)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "MessageBox",
               "<script language='javascript'>alert('" + Message + "');</script>"
            );
        }
    }
}