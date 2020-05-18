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
    public partial class display_order : System.Web.UI.Page
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
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from orders where email=?email order by id DESC";
                cmd.Parameters.Add(new MySqlParameter("email",Session["user"].ToString()));
                //cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                r1.DataSource = dt;
                r1.DataBind();
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