using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class Child1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a  = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
           
            sp1.InnerText = a.ToString();
        }
    }
}