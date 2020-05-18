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
    public partial class update_order_details : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            try
            {
                if (IsPostBack) { return; }
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from registration where email=?email";
                cmd.Parameters.Add(new MySqlParameter("email", Session["user"].ToString()));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    fname.Text = dr["fname"].ToString();
                    lname.Text = dr["lname"].ToString();
                    address.Text = dr["address"].ToString();
                    city.Text = dr["city"].ToString();
                    state.Text = dr["state"].ToString();
                    mobile.Text = dr["mobile"].ToString();
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

        protected void b1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update registration set fname=?fname,lname=?lname,address=?address,city=?city,state=?state,mobile=?mobile where email=?email";
                cmd.Parameters.Add(new MySqlParameter("email",Session["user"].ToString()));
                cmd.Parameters.Add(new MySqlParameter("fname",fname.Text));
                cmd.Parameters.Add(new MySqlParameter("lname", lname.Text));
                cmd.Parameters.Add(new MySqlParameter("address", address.Text));
                cmd.Parameters.Add(new MySqlParameter("city", city.Text));
                cmd.Parameters.Add(new MySqlParameter("state", state.Text));
                cmd.Parameters.Add(new MySqlParameter("mobile",mobile.Text ));
                cmd.ExecuteNonQuery();
            }
            catch (Exception az)
            {
                Response.Write(az.Message);
            }
            finally
            {
                cn.Close();
                Response.Redirect("payment_gateway.aspx");
            }
        }
    }
}