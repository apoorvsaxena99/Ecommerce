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
    public partial class Registration : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd4 = cn.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "insert into credits(email,wallet) values(?email,?wallet)";
                cmd4.Parameters.Add(new MySqlParameter("wallet",0));
                cmd4.Parameters.Add(new MySqlParameter("email", email.Text));
                cmd4.ExecuteNonQuery();
            }
            catch (Exception az)
            {
                Response.Write(az.Message);
            }
            finally
            {
                cn.Close();
            }
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into registration(fname,lname,email,password,address,city,state,pincode,mobile) values(?fname,?lname,?email,?password,?address,?city,?state,?pincode,?mobile)";
                cmd.Parameters.Add(new MySqlParameter("fname", fname.Text));
                cmd.Parameters.Add(new MySqlParameter("lname", lname.Text));
                cmd.Parameters.Add(new MySqlParameter("email", email.Text));
                cmd.Parameters.Add(new MySqlParameter("password", password.Text));
                cmd.Parameters.Add(new MySqlParameter("address", address.Text));
                cmd.Parameters.Add(new MySqlParameter("city", city.Text));
                cmd.Parameters.Add(new MySqlParameter("state", state.Text));
                cmd.Parameters.Add(new MySqlParameter("pincode", pincode.Text));
                cmd.Parameters.Add(new MySqlParameter("mobile", mobile.Text));
                cmd.ExecuteNonQuery();
            }
            catch (Exception az)
            {
                Response.Write(az.Message);
            }
            finally
            {
                cn.Close();
                fname.Text = "";
                lname.Text = "";
                email.Text = "";
                password.Text = "";
                address.Text = "";
                city.Text = "";
                state.Text = "";
                pincode.Text = "";
                mobile.Text = "";
                Label1.Text = "Registration Successfully Saved";
            }
            ScriptManager.RegisterClientScriptBlock(Page, typeof(string), "update", "Show();", true);
            Response.Redirect("Login.aspx");
        }
    }
}