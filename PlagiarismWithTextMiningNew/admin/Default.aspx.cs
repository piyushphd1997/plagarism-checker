﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
       // Response.Redirect("ViewDetails.aspx?reqid=" + GridView1.SelectedRow.Cells[1].Text + "&reqfrom=" + GridView1.SelectedRow.Cells[2].Text + "&reqto=" + GridView1.SelectedRow.Cells[3].Text);
    }
}