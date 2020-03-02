using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_ViewDetails : System.Web.UI.Page
{

    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
       
    }
    protected void btnReject_Click(object sender, EventArgs e)
    {
       
    }

    protected void setStatus(string status)
    {
        

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {


    
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string str = GridView1.SelectedRow.Cells[1].Text.ToString();
        // Response.Write("Value="+ GridView1.SelectedRow.Cells[1].Text.ToString()+"sagar");
        if (str.Equals("&nbsp;"))
        {


        }
        else
        {
            int pid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text.ToString());

            con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select pname from Papers where pid=" + pid;
            cmd.Connection = con;
            SqlDataReader obj = cmd.ExecuteReader();
            if (obj.Read())
            {
                if (obj.GetString(0) == "")
                {

                }
                else
                {

                    Response.ContentType = "Application/octect-stream";
                    Response.AppendHeader("Content-Disposition", "filename=" + obj.GetString(0) + "");
                    Response.TransmitFile(Server.MapPath("Paper/" + obj.GetString(0) + ""));
                    Response.End();
                }
            }
            con.Close();

        }
    }
}