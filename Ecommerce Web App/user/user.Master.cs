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
    public partial class user : System.Web.UI.MasterPage
    {
        string s, t;
        string[] a = new string[6];
        int tot = 0,count=0;
        MySqlConnection cn = new MySqlConnection();
        int id, qty;
        string product_name, product_desc, product_price, product_qty, product_images;
        protected void Page_Load(object sender, EventArgs e)
        {
            try 
            {
                if (Session["user"] == null)
                {
                    Wallet.Text = "0";
                }
                else
                {
                    cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                    cn.Open();
                    MySqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select wallet from credits where email=?email";
                    cmd.Parameters.Add(new MySqlParameter("email", Session["user"].ToString()));
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Wallet.Text = dr["wallet"].ToString();
                    }
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
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd1 = cn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from product_category";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                da1.Fill(dt1);
                dd.DataSource = dt1;
                dd.DataBind();
            }
            catch (Exception az)
            {
                Response.Write(az.Message);
            }
            finally
            {
                cn.Close();
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
                    
                    tot = tot + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
                    count += 1;
                    cartitem.Text = count.ToString();
                    cartprice.Text = tot.ToString();
                }
            }
        }
    }
}