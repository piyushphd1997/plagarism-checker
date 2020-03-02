using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for BasicCode
/// </summary>
public class BasicCode
{

    public string generateID(string col, string tbl)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);

        cmd = new SqlCommand();
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "select " + col + " from  " + tbl + " order by " + col + " desc";
        cmd.Connection = con;
        object obj = cmd.ExecuteScalar();
        con.Close();
        if (obj == null)
        {
            return "1";
        }
        else
        {
            int n = Convert.ToInt32(obj);
            n = n + 1;
            return n.ToString();
        }

    }

    public void send(string to, string subject, string body)
    {
        //StreamReader reader = new StreamReader(Microsoft.SqlServer.Server.MapPath("~/MailBody.htm"));
        //string readFile = reader.ReadToEnd();
        string myString = "";
        //  myString = readFile;
        //myString = myString.Replace("$$Admin$$", "Suresh Dasari");
        //myString = myString.Replace("$$CompanyName$$", "Dasari Group");
        //myString = myString.Replace("$$Email$$", "suresh@gmail.com");
        //myString = myString.Replace("$$Website$$", "http://www.laksh.com");

        //string to = Session["username"].ToString();
        string from = "amitssawarkar@gmail.com";
        //string subject = "Result";
        //string body = "YOUR RESULT IS  TOTAL MARKS : 20 OBTAINED MARKS :'" + lblmarks.Text + "'";
        using (MailMessage mm = new MailMessage(from, to))
        {
            mm.Subject = subject;
            mm.Body = body;
            //if (fuAttachment.HasFile)
            //{
            //    string FileName = Path.GetFileName(fuAttachment.PostedFile.FileName);
            //    mm.Attachments.Add(new Attachment(fuAttachment.PostedFile.InputStream, FileName));
            //}
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential("smartdonor5@gmail.com", "9503351933");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);
            //ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
        }
    }

    public void SendSms(string senderid, string mob, string msg)
    {
        //Your authentication key
        string authKey = "87435AuVpkXDV558b97ae";
        //Multiple mobiles numbers separated by comma
        string mobileNumber = "91" + mob;
        //Sender ID,While using route4 sender id should be 6 characters long.
        string senderId = senderid;
        //Your message to send, Add URL encoding here.
        string message = HttpUtility.UrlEncode(msg);

        //Prepare you post parameters
        StringBuilder sbPostData = new StringBuilder();
        sbPostData.AppendFormat("authkey={0}", authKey);
        sbPostData.AppendFormat("&mobiles={0}", mobileNumber);
        sbPostData.AppendFormat("&message={0}", message);
        sbPostData.AppendFormat("&sender={0}", senderId);
        sbPostData.AppendFormat("&route={0}", "4");

        try
        {
            //Call Send SMS API
            string sendSMSUri = "http://msg.worldtechsofts.com/api/sendhttp.php";
            //Create HTTPWebrequest
            HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(sendSMSUri);
            //Prepare and Add URL Encoded data
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] data = encoding.GetBytes(sbPostData.ToString());
            //Specify post method
            httpWReq.Method = "POST";
            httpWReq.ContentType = "application/x-www-form-urlencoded";
            httpWReq.ContentLength = data.Length;
            using (Stream stream = httpWReq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            //Get the response
            HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseString = reader.ReadToEnd();

            //Close the response
            reader.Close();
            response.Close();
        }
        catch (SystemException ex)
        {

        }

    }

}