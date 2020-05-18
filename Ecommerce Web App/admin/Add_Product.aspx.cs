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
    public partial class Add_Product : System.Web.UI.Page
    {
        string a, b;
        MySqlConnection cn = new MySqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null) 
            {
                Response.Redirect("~/AdminLogin.aspx");
            }
            try
            {
                if (IsPostBack) { return; }
                dd.Items.Clear();
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product_category";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    dd.Items.Add(dr["category"].ToString());
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

        protected void Upload_Click(object sender, EventArgs e)
        {
            a = Class1.GetRandomPassword(10).ToString();
            image.SaveAs(Request.PhysicalApplicationPath + "./images/"+a+image.FileName.ToString());
            b="images/"+a+image.FileName.ToString();
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                string str = "insert into product(product_name,product_desc,product_price,product_qty,product_images,product_category) values(?product_name,?product_desc,?product_price,?product_qty,?product_images,?product_category)";
                MySqlCommand cmd = new MySqlCommand(str, cn);
                cmd.Parameters.Add(new MySqlParameter("product_name", name.Text));
                cmd.Parameters.Add(new MySqlParameter("product_price", price.Text));
                cmd.Parameters.Add(new MySqlParameter("product_qty", quantity.Text));
                cmd.Parameters.Add(new MySqlParameter("product_desc", description.Text));
                cmd.Parameters.Add(new MySqlParameter("product_images", b.ToString()));
                cmd.Parameters.Add(new MySqlParameter("product_category",dd.SelectedItem.ToString()));
                cmd.ExecuteNonQuery();
                
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