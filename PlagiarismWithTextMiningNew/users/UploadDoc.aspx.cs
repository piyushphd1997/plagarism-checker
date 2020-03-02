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

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
    
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
        if (FileUploadWord.HasFile)
        {

            int pid = generate_ID();

            string str = FileUploadWord.FileName;
            int pos = str.LastIndexOf(".");
            string ext = str.Substring(pos + 1);
            string fname = "P_" + pid + "." + ext;
            string upath = Server.MapPath("../Admin/Paper");
            String ppath = upath + "\\" + fname;
            FileUploadWord.SaveAs(ppath);
            Session.Add("pname", fname);


            //Pdf data

            //string file = FileUploadWord.FileName;
            //FileUploadWord.SaveAs(Server.MapPath(file));
            //StringBuilder textPdf = new StringBuilder();
            //PdfReader reader = new PdfReader(Server.MapPath(file));
            ////Response.Write(reader.NumberOfPages.ToString());
            //for (int i = 1; i <= reader.NumberOfPages; i++)
            //{
            //    ITextExtractionStrategy objExtractStrategy = new SimpleTextExtractionStrategy();
            //    string strLineText = PdfTextExtractor.GetTextFromPage(reader, i, objExtractStrategy);
            //    strLineText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(strLineText)));
            //    textPdf.Append(strLineText);
            //}

            //reader.Close();
            //TextBox1.Text = TextBox1.Text + " " + textPdf.ToString();

            string file = FileUploadWord.FileName;
            FileUploadWord.SaveAs(Server.MapPath(file));
            StringBuilder textWord = new StringBuilder();
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            object miss = System.Reflection.Missing.Value;
            object path = @Server.MapPath(file);
            object readOnly = true;
            Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);

            for (int i = 0; i < docs.Paragraphs.Count; i++)
            {
                textWord.Append(" \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString());
            }
            //TextBox1.Text = text.ToString();
            // text.Append(textWord.ToString());
            TextBox1.Text = TextBox1.Text + " " + textWord.ToString();
            docs.Close();


            string path1 = null;
            path1 = Server.MapPath("~/Paper/AllPaper.txt");

            File.WriteAllText(path1, TextBox1.Text.Trim());

            lblMsg.Text = "Synopsis Data Save Successfully...";
            lblMsg.Visible = true;

        }

    }
    protected void txtAdhar_TextChanged(object sender, EventArgs e)
    {
       
    }

   

}