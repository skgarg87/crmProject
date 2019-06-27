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
            ViewState["abc"] = "viewstates 30 seconds";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = ViewState["abc"].ToString();
        }
    }
}