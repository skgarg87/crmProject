using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitProjects
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["abc"] = "session 30 seconds";
            //pppp
            //abc
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Label1.Text = ViewState["abc"].ToString();
        }
    }
}