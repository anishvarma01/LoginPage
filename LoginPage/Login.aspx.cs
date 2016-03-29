using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LoginPage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Cs = ConfigurationManager.ConnectionStrings["OrganisationConnectionString"].ConnectionString;
            SqlConnection mycon = new SqlConnection(Cs);
            mycon.Open();
            SqlCommand cmd = new SqlCommand("select *from Registration where UserName=@UserName", mycon);

            cmd.Parameters.AddWithValue("@UserName", logUn.Text);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            SqlCommand cmd2 = new SqlCommand("select *from Registration where Pwd=@Pwd", mycon);

            cmd2.Parameters.AddWithValue("@Pwd", logPw.Text);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd2);
            DataTable dt1 = new DataTable();
            adp1.Fill(dt1);
            if (dt.Rows.Count > 1 && dt1.Rows.Count > 1)

            {
                Response.Write("Login Successful!!!!");
                mycon.Close();


            }
            else
            {
                Response.Write("Login Failed!!!");
            }
        }

        protected void logUn_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Reg_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Register.aspx");
        }
    }
}