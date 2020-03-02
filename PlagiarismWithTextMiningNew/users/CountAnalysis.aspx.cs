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
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            int count = 0;
            int ocount = 0;
            float per = 0;
            float max = 0;
            con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select pname from Papers";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Read file from location
                string pname = dr.GetString(0).ToString();
               

                //reader.Close();
                //TextBox1.Text = TextBox1.Text + " " + textPdf.ToString();


                //word File Code
                //   string file =pname;
                StringBuilder textWord = new StringBuilder();
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                object miss = System.Reflection.Missing.Value;
                object path = @Server.MapPath("~/Admin/Paper/" + pname);
                object readOnly = true;
                Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);

                for (int i = 0; i < docs.Paragraphs.Count; i++)
                {
                    textWord.Append(" \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString());
                }
                //TextBox1.Text = text.ToString();
                // text.Append(textWord.ToString());

                docs.Close();




                //Compare file

                string newfile = "~/Paper/AllPaper.txt";//path to text file
                StreamReader testTxt1 = new StreamReader(Server.MapPath(newfile));
                string text1 = testTxt1.ReadToEnd();
                // Split the text block into an array of sentences.

                string[] sentences1 = text1.Split(new char[] { '.', '?', '!', ',' });
                // Response.Write(sentences1[1]);
                for (int i = 0; i < sentences1.Length; i++)
                {

                    // string oldfile = textPdf.ToString();//path to text file
                    // StreamReader testTxt = new StreamReader(Server.MapPath(oldfile));
                    string text = textWord.ToString();
                    // Split the text block into an array of sentences.

                    string[] sentences = text.Split(new char[] { '.', '?', '!' });
                    ocount = sentences.Length;
                    // Define the search terms. This list could also be dynamically populated at runtime.


                    string[] wordsToMatch;
                    wordsToMatch = new string[1];
                    wordsToMatch[0] = sentences1[i];
                    // Find sentences that contain all the terms in the wordsToMatch array.
                    // Note that the number of terms to match is not specified at compile time.
                    var sentenceQuery = from sentence in sentences
                                        let w = sentence.Split(new char[] { '.', '?', '!', ';', ':', ',' },

                                                                StringSplitOptions.RemoveEmptyEntries)

                                        where w.Distinct().Intersect(wordsToMatch).Count() == wordsToMatch.Count()

                                        select sentence;
                    foreach (string str in sentenceQuery)
                    {
                        //  Response.Write("Hloo");
                        // Response.Write(str + ".");
                        //  txtFirstItem.Text = txtFirstItem.Text + " " + str + ".";
                        count++;
                        break;

                    }
                    //    Response.Write("Hloo");
                    // testTxt.Close();

                }
                //end for loop


                per = (count * 100) / ocount;
                if (per > max)
                {
                    max = per;
                }

            }
            //  float val = count / ocount;

            if (max > 100)
                lblCount.Text = "100";
            else
                lblCount.Text = max.ToString();

            if (max < 20)
            {
                lblStatus.Text = "Accepted";
            }
            else
            {
                lblStatus.Text = "Rejected";
            }
        }
    }

    protected int generate_ID()
    {
        try
        {
            con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select pid from Papers order by pid desc";
            cmd.Connection = con;
            object obj = cmd.ExecuteScalar();
            if (obj == null)
            {
                return 2000;
            }
            else
            {
                int n = Convert.ToInt32(obj);
                n = n + 1;
                return n;
            }

            con.Close();
        }
        catch (Exception er)
        {
            return 0;
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        // Response.Write("PID=" + generate_ID());
        if (lblStatus.Text == "Accepted")
        {

            con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from Papers where uid=" + Session["id"] + "";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblMsg.Text = "Your Document already exist.....";
                lblMsg.Visible = true;
            }
            else
            {
                int pid = generate_ID();

                con = new SqlConnection(ConfigurationManager.AppSettings["LIS"]);
                cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "insert into Papers(pid,pname,pdesc,uid,status)values(@pid,@pname,@pdesc,@uid,@status)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@pid", pid);

                cmd.Parameters.AddWithValue("@pname", Session["pname"]);
                cmd.Parameters.AddWithValue("@pdesc", txtDesc.Text);
                cmd.Parameters.AddWithValue("@uid", Session["id"]);
                cmd.Parameters.AddWithValue("@status", "Accepted");

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    lblMsg.Visible = true;
                    txtDesc.Text = "";
                    lblMsg.Text = "Document Save Save Successfully.....";
                }
            }
        }
        else
        {
            lblMsg.Text = "Your Document rejected.....";
            lblMsg.Visible = true;
        }
        
    }
    protected void txtAdhar_TextChanged(object sender, EventArgs e)
    {
       
    }

   

}