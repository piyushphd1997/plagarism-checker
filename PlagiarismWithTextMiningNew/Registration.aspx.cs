using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        generate_ID();
    }

    protected void generate_ID()
    {
        try
        {
            con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select id from Registration order by id desc";
            cmd.Connection = con;
            object obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                txtID.Text = "100";
            }
            else
            {
                int n = Convert.ToInt32(obj);
                n = n + 1;
                txtID.Text = n.ToString();
            }
            con.Close();
        }
        catch (Exception er)
        { }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            string upath = Server.MapPath("Users");
            String ppath = upath + "\\photos" + "\\" + FileUpload1.FileName.ToString();
            FileUpload1.SaveAs(ppath);

            con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "insert into Registration(id,rollno,uname,mobileno,emailid,address,userid,pwd,photo)values(@id,@rollno,@uname,@mobileno,@emailid,@address,@userid,@pwd,@photo)";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@rollno", txtRollNo.Text);
            cmd.Parameters.AddWithValue("@uname", txtName.Text);
            cmd.Parameters.AddWithValue("@mobileno", txtMobileNo.Text);
            cmd.Parameters.AddWithValue("@emailid", txtEmailid.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@userid", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
            cmd.Parameters.AddWithValue("@photo", FileUpload1.FileName.ToString());
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                con.Close();
                Response.Redirect("Login.aspx");
            }
            con.Close();
        }
        catch (Exception er)
        { Response.Write(er.ToString()); }
    }
    protected void txtAdhar_TextChanged(object sender, EventArgs e)
    {
       
    }

   

}