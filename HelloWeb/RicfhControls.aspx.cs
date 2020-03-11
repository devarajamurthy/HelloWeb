using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class RicfhControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Books> books = Books.GetPagedBooks(1,3);

                Grid1.DataSource = books;
                Grid1.DataBind();
            }


        }
    }
}