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
    public partial class product_description : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection();
        int id,qty;
        string product_name, product_desc, product_price, product_qty, product_images;
        protected void Page_Load(object sender, EventArgs e)
        {
            id=Convert.ToInt32(Request.QueryString["id"]);
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                if (id==0)
                {
                    Response.Redirect("display_item.aspx");
                }
                else
                {
                    MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from product where id=?id";
                    cmd.Parameters.Add(new MySqlParameter("id", id));
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    d1.DataSource = dt;
                    d1.DataBind();
                    MySqlCommand cmd1 = cn.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select r.name,r.review from review_product as r inner join order_details as o ON r.order_id=o.id where o.product_name=(select product_name from product where id=?id)";
                    cmd1.Parameters.Add(new MySqlParameter("id", id));
                    cmd1.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    da1.Fill(dt1);
                    d2.DataSource = dt1;
                    d2.DataBind();
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
            qty = get_qty(id);
            if (qty == 0)
            {
                l2.Visible = false;
                t1.Visible = false;
                Cart.Visible = false;
                l1.Text = "There Is No Available Quantity Of This Item";
            }
        }

        protected void Cart_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                { cn.Close(); }
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                //id = Convert.ToInt32(Request.QueryString["id"].ToString());
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product where id=?id";
                cmd.Parameters.Add(new MySqlParameter("id", id));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    product_name = dr["product_name"].ToString();
                    product_desc = dr["product_desc"].ToString();
                    product_price = dr["product_price"].ToString();
                    product_qty = dr["product_qty"].ToString();
                    product_images = dr["product_images"].ToString();
                }
                
                if (Convert.ToInt32(t1.Text) > Convert.ToInt32(product_qty))
                {
                    l1.Text = "Please Enter Lower Quantity";
                }
                else
                {
                    l1.Text = "";
                    if (Request.Cookies["aa"] == null)
                    {
                        Response.Cookies["aa"].Value = product_name.ToString() + "," + product_desc.ToString() + "," + product_price.ToString() + "," + t1.Text + "," + product_images.ToString() + "," + id.ToString();
                        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                    }
                    else
                    {
                        Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + product_name.ToString() + "," + product_desc.ToString() + "," + product_price.ToString() + "," + t1.Text + "," + product_images.ToString() + "," + id.ToString(); 
                        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                    }
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update product set product_qty=product_qty-" + t1.Text + " where id="+id;
                    cmd.ExecuteNonQuery();
                    Response.Redirect("product_description.aspx?id=" + id.ToString());
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

        public int get_qty(int id)
        {
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from product where id=?id";
                    cmd.Parameters.Add(new MySqlParameter("id", id));
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        qty = Convert.ToInt32(dr["product_qty"].ToString());
                    }
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
            return qty;
        }
    }
}