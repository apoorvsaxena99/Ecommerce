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
    public partial class view_cart : System.Web.UI.Page
    {
        string s, t;
        string[] a = new string[6];
        int tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("product_name"), new DataColumn("product_desc"), new DataColumn("product_price"), new DataColumn("product_qty"), new DataColumn("product_images"), new DataColumn("id"), new DataColumn("product_id") });
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
                    dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), i.ToString(), a[5].ToString());
                    tot = tot + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
                }
            }
            d1.DataSource = dt;
            d1.DataBind();
            if (tot <= 0)
            {
                l1.Text = "Please Add An Item";
                b1.Visible = false;
                d1.Visible = false;
            }
            else {
                l1.Text = "Total Amount You Have To Pay=" + tot.ToString();
            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            Session["checkoutbutton"] = "yes";
            Session["Total"] = tot;
            Response.Redirect("checkout.aspx");
        }
    }
}