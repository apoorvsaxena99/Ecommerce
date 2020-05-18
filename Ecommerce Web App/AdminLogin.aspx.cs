using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace Ecommerce_Web_App
{
    public partial class AdminLogin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            { 
            cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
            cn.Open();
            string str = "select * from adminlogin where email=?email and password=?password";
            MySqlCommand cmd = new MySqlCommand(str, cn);
            cmd.Parameters.Add(new MySqlParameter("email", email.Text));
            cmd.Parameters.Add(new MySqlParameter("password", pass.Text));
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["email"] = email.Text;
                dr.Close();
                cn.Close();
                Response.Redirect("~/admin/Add_Product.aspx");
            }
            else
            {
                if ((String.IsNullOrEmpty(email.Text)) && (String.IsNullOrEmpty(pass.Text)))
                {
                    msg.Text="Please Enter Email and Password";
                }
                else if (String.IsNullOrEmpty(email.Text))
                {
                    msg.Text="Please Enter Email";
                }
                else if (String.IsNullOrEmpty(pass.Text))
                {
                    msg.Text="Please Enter Password";
                }
                else
                {
                    msg.Text="Wrong Id Or Password";
                }

            }
            }
            catch (Exception a)
            {
                msg.Text = a.Message;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}