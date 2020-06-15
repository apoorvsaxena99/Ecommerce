using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Ecommerce_Web_App.user
{
    public partial class login : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection();
        int tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from registration where email=?email AND password=?password";
                cmd.Parameters.Add(new MySqlParameter("email", email.Text));
                cmd.Parameters.Add(new MySqlParameter("password", password.Text));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                tot = Convert.ToInt32(dt.Rows.Count.ToString());
                if (tot > 0)
                {
                    if (Session["checkoutbutton"] == "yes")
                    {
                        Session["user"] = email.Text;
                        Response.Redirect("update_order_details.aspx");
                    }
                    else
                    {
                        Session["user"] = email.Text;
                        Response.Redirect("order_details.aspx");
                    }
                }
                else {
                    Label.Text = "Invalid Email-ID or Password";
                }
            }
            catch (Exception az)
            {
                Response.Write(az.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        protected void Registration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}