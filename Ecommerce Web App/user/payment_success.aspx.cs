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
    public partial class payment_success : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection();
        string order = "", s, t,email;
        int order_id = 0;
        string[] a=new string[6];
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                if (Session["user"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                email = Session["user"].ToString();
                order = Request.QueryString["order"].ToString();
                if (order == Session["order_no"].ToString())
                {
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
                        MySqlCommand cmd1 = cn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "insert into orders(fname,lname,email,address,city,state,pincode,mobile) values(?fname,?lname,?email,?address,?city,?state,?pincode,?mobile)";
                        cmd1.Parameters.Add(new MySqlParameter("fname", dr["fname"].ToString()));
                        cmd1.Parameters.Add(new MySqlParameter("lname", dr["lname"].ToString()));
                        cmd1.Parameters.Add(new MySqlParameter("email", dr["email"].ToString()));
                        cmd1.Parameters.Add(new MySqlParameter("address", dr["address"].ToString()));
                        cmd1.Parameters.Add(new MySqlParameter("city", dr["city"].ToString()));
                        cmd1.Parameters.Add(new MySqlParameter("state", dr["state"].ToString()));
                        cmd1.Parameters.Add(new MySqlParameter("pincode", dr["pincode"].ToString()));
                        cmd1.Parameters.Add(new MySqlParameter("mobile", dr["mobile"].ToString()));
                        cmd1.ExecuteNonQuery();
                    }
                    MySqlCommand cmd2 = cn.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select id from orders where email=?email order by id desc LIMIT 1";
                    cmd2.Parameters.Add(new MySqlParameter("email",email));
                    cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                    da2.Fill(dt2);
                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        order_id = Convert.ToInt32(dr2["id"].ToString());
                    }
                    if (Request.Cookies["aa"] != null)
                    {
                        s = Convert.ToString(Request.Cookies["aa"].Value);
                        string[] strArr = s.Split('|');
                        for (int i = 0; i < strArr.Length; i++)
                        {
                            t = Convert.ToString(strArr[i].ToString());
                            string[] strArr1 = t.Split(',');
                            for (int j = 0; j < strArr1.Length; j++)
                            {
                                a[j] = strArr1[j].ToString();
                            }
                            MySqlCommand cmd3 = cn.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "insert into order_details(order_id,product_name,product_price,product_qty,product_images) values(?order_id,?product_name,?product_price,?product_qty,?product_images)";
                            cmd3.Parameters.Add(new MySqlParameter("order_id", order_id));
                            cmd3.Parameters.Add(new MySqlParameter("product_name", a[0].ToString()));
                            cmd3.Parameters.Add(new MySqlParameter("product_price", a[2].ToString()));
                            cmd3.Parameters.Add(new MySqlParameter("product_qty", a[3].ToString()));
                            cmd3.Parameters.Add(new MySqlParameter("product_images", a[4].ToString()));
                            cmd3.ExecuteNonQuery();
                        }
                    }

                }
                else {

                    Response.Redirect("login.aspx");
                }

            }
            catch (Exception az)
            {

                Response.Write(az.Message);
            }
            finally
            {
                cn.Close();
                Session["user"]="";
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("display_item.aspx");
            }

        }
    }
}