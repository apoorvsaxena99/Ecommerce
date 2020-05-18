using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ecommerce_Web_App.user
{
    public partial class payment_gateway : System.Web.UI.Page
    {
        int tot = 0;
        string s, t, order_no;
        string[] a=new string[6];
        MySqlConnection cn = new MySqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) { return; }
            
                if (Session["user"] == null)
                {
                    Response.Redirect("login.aspx");
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
                    }
                    Session["tot"] = tot.ToString();
                }


                /*Response.Write("form action='http://www.sandbox.paypal.com/cgi-bin/webscr' method='post' name='buyCredits' id='buyCredits'>");
                Response.Write("<input type 'hidden' name='cmd' value='_xclick'>");
                Response.Write("<input type='hidden' name='business' value='amit_1266030690@gmail.com'>");
                Response.Write("<input type='hidden' name='currency_cide' value='USD'>");
                Response.Write("<input type='hidden' name='item_name' value='payment for purchase'>");
                Response.Write("<input type='hidden' name='item_number' value='0'>");
                Response.Write("<input type='hidden' name='amount' value='" + Session["tot"].ToString() + "'>");
                Response.Write("<input type='hidden' name='return' value='http://localhost:32601/user/payment_success.aspx?order=" + order_no.ToString() + "'>");
                Response.Write("</form>");
                Response.Write("<script type='text/javascript'>");
                Response.Write("document.getElementById('buyCredits').submit();");
                Response.Write("</script>");*/
                Response.Write(Session["user"].ToString());
                Total.Text = tot.ToString();
            }

        protected void pay_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select password from registration where email=?email and password=?password";
                cmd.Parameters.Add(new MySqlParameter("email", Session["user"].ToString()));
                cmd.Parameters.Add(new MySqlParameter("password", TextBox1.Text));
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    order_no = Class1.GetRandomPassword(10).ToString();
                    Session["order_no"] = order_no.ToString();
                    Response.Redirect("payment_success.aspx?order=" + order_no.ToString() + "");
                }
                else
                {
                    Response.Write("You Have Entered Wrong Password So Plz order Again");
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
    }
}