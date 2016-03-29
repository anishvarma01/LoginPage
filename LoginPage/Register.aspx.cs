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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(IsPostBack)
            //{ 
            ////string Cs = ConfigurationManager.ConnectionStrings["OrganisationConnectionString"].ConnectionString;
            ////SqlConnection mycon = new SqlConnection(Cs) ;
            ////    mycon.Open();

            //    //SqlCommand cmd = new SqlCommand("select *from Registration where UserName=@UserName",mycon);

            //    //cmd.Parameters.AddWithValue("@UserName",txtUserName.Text);
            //    //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //    //DataTable dt = new DataTable();
            //    //adp.Fill(dt);
            //    //if (dt.Rows.Count>1)

            //    //{
            //    //    Response.Write("UserName already exists");
                    
            //    //}//String CkUn = "select count(*) from Registration where UserName="+txtUserName.Text;
            //    //SqlCommand cmd = new SqlCommand(CkUn, mycon);
            //    //int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            //    //if(temp == 1)
            //    //{
            //    //    Response.Write("Oops!!! User Already Exists");
            //    //}
            /////    mycon.Close();
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //   Response.Write("Registration Successful");
            string Cs = ConfigurationManager.ConnectionStrings["OrganisationConnectionString"].ConnectionString;
            SqlConnection mycon = new SqlConnection(Cs);
            mycon.Open();
            // string connectionString1 = "Data Source=.;Initial Catalog=Organisation;Integrated Security=true;";
            //  string Cs = ConfigurationManager.ConnectionStrings["OrganisationConnectionString"].ConnectionString;


            SqlCommand cmd = new SqlCommand("select *from Registration where UserName=@UserName", mycon);

            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            SqlCommand cmd2 = new SqlCommand("select *from Registration where Email=@Email", mycon);

            cmd2.Parameters.AddWithValue("@Email", txtEmail.Text);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataTable dt3 = new DataTable();
            adp2.Fill(dt3);
            if (dt.Rows.Count > 1 || dt3.Rows.Count>1)

            {
                Response.Write("UserName or emailid already exists");
                mycon.Close();

            }
           
           else
                {

                string Cs1 = ConfigurationManager.ConnectionStrings["OrganisationConnectionString"].ConnectionString;
                //  using (SqlConnection mycon = new SqlConnection(connectionString1))
                using (SqlConnection mycon1 = new SqlConnection(Cs1))
                    {
                        try
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert into Registration values(@UserName,@Email,@PassWord,@Country)", mycon1);

                            cmd1.Parameters.AddWithValue("@UserName", txtUserName.Text);
                            cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd1.Parameters.AddWithValue("@PassWord", txtPwd.Text);
                            cmd1.Parameters.AddWithValue("@Country", ddlCountryName.SelectedItem.Text);
                            mycon1.Open();
                            cmd1.ExecuteNonQuery();
                            mycon1.Close();
                        }
                        catch (Exception ex)
                        {
                            Response.Write("Error" + ex.ToString());
                        }

                    }
                    //using (SqlConnection scon = new SqlConnection(Con))
                    //{

                    //}

                    Response.Redirect("/Manager.aspx");

                    //GridView1.DataSource = SqlDataSource1;
                    //GridView1.DataBind();
                }
            
        }
        protected void TextBoxPW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}