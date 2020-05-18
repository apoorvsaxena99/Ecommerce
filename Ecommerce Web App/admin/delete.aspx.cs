using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace Ecommerce_Web_App.admin
{
    public partial class delete : System.Web.UI.Page
    {
        string category;
        MySqlConnection cn = new MySqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            category = Request.QueryString["category"].ToString();
            cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
            cn.Open();
            MySqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from product_category where category=?category";
            cmd.Parameters.Add(new MySqlParameter("category",category));
            cmd.ExecuteNonQuery();
            cn.Close();
            Response.Redirect("add_category.aspx");
        }
    }
}