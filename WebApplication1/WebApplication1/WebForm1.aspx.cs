using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Price");
            dt.Rows.Add("123");
            dt.Rows.Add("123");
            dt.Rows.Add("123");
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
    }
}