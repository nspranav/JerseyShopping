using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JerseyShopping
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = string.Empty;
            int total = 0;
            List<Jersey> js = (List<Jersey>)Session["jersey"];
            MessageBox.Show(this, js.Count.ToString());
            foreach(Jersey j in js)
            {
                s +="<div class=\"row\">";
                s += "<div class=\"col-lg-4\">";
                s += "<a href = 'Images/" + j.img + "' class='thumbnail'>";
                s += "<img src = 'Images/" + j.img + " ' style='width:150px;height:150px'/>";
                s += "</a></div>";
                s += "<div class=\"col-lg-4\">";
                s += "<p> Quantity:" + j.qty + "</p></div>";
                s += "<div class=\"col-lg-4\"><p> Cost:" + j.qty * 10 + "</p></div>";
                total += j.qty * 10;
                s += "</div>";
            }
            s += "<pre style='text-align:center'> Your Total is " + total + "</pre>";
            ltNotify.Text = s;
        }
    }
}