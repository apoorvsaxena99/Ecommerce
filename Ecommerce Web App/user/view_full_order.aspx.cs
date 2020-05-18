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
    public partial class view_full_order : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                int id, tot = 0;
                try
                {
                    id = Convert.ToInt32(Request.QueryString["id"].ToString());
                    cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                    cn.Open();
                    /*MySqlCommand cmd2 = cn.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select order_id from review_product where order_id=?id";
                    cmd2.Parameters.Add(new MySqlParameter("id", id));
                    MySqlDataReader dr1 = cmd2.ExecuteReader();
                    /*if (dr1.Read())
                    {
                        
                    }*/
                    MySqlCommand cmd1 = cn.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from orders where id=?id";
                    cmd1.Parameters.Add(new MySqlParameter("id", id));
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    r2.DataSource = dt1;
                    r2.DataBind();
                    MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from order_details where order_id=" + id + "";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    r1.DataSource = dt;
                    r1.DataBind();
                    foreach (DataRow dr in dt.Rows)
                    {
                        tot += (Convert.ToInt32(dr["product_price"].ToString()) * Convert.ToInt32(dr["product_qty"].ToString()));
                    }
                }
                catch (Exception az) { Response.Write(az.Message); }
                finally
                {
                    cn.Close();
                }
                ll.Text = "Total Order Price:-\t" + tot.ToString();
            }
        }
    }
}