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
    public partial class display_item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (Request.QueryString["category"] == null)
                {
                    cmd.CommandText = "select * from product";
                }
                else 
                {
                    cmd.CommandText = "select * from product where product_category=?product_category";
                    cmd.Parameters.Add(new MySqlParameter("product_category", Request.QueryString["category"].ToString()));
                }
                if (Request.QueryString["category"] == null && Request.QueryString["search"] != null)
                {
                    cmd.CommandText = "select * from product where product_name like('%"+Request.QueryString["search"].ToString()+"')";
                }
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();

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
    }
}