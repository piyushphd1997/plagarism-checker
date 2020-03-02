using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

      
     

            con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select userid,pwd,id from Registration where userid='" + txtUser.Text + "' and pwd='" + txtPwd.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session.Add("id", dr.GetInt32(2));
                Response.Redirect("Users/Profile.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Username & Password')", true);
            }

        
    }
}