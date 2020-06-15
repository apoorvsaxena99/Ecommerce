using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Ecommerce_Web_App.user
{
    public partial class review : System.Web.UI.Page
    {
        int id=0,Wallet = 0;
        string name = "";
        MySqlConnection cn = new MySqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }
        protected void Post_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd2 = cn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select fname from orders where id=(select order_id from order_details where id=?id)";
                cmd2.Parameters.Add(new MySqlParameter("id", id));
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    name = dr2["fname"].ToString();
                }
                MySqlCommand cmd3 = cn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into review_product(order_id,review,name) values(?order_id,?review,?name)";
                cmd3.Parameters.Add(new MySqlParameter("order_id",id));
                cmd3.Parameters.Add(new MySqlParameter("name",name));
                cmd3.Parameters.Add(new MySqlParameter("review",Show.Text));
                cmd3.ExecuteNonQuery();
                abc.Text = "Your Review Has Been Posted Successfully..!!";
            }
            catch (Exception az)
            {
                Response.Write(az.Message);
            }
            finally
            {
                cn.Close();
                SplitString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("display_item.aspx");
            }
            
            //string[] msg =Show.Text.ToArray();
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("display_item.aspx");
        }
        private void SplitString()
        {
            /*ArrayList splitted = new ArrayList();

            string[] words = Show.Text.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            var word_query =
                (from string word in words
                 orderby word
                 select word).Distinct();

            string[] result = word_query.ToArray();*/
            
            try
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
                        Wallet=Convert.ToInt32(dr["wallet"].ToString());
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
            string[] allLines = Show.Text.Split(' ');
            string[] words = { "Good", "Nice", "Excellent", "Perfect", "Awesome" };
            string[] words1 = { "Bad", "Poor", "Rubbish", "Wrong" };
            string[] show = allLines.Intersect(words, StringComparer.OrdinalIgnoreCase).ToArray();
            if (show.Length > 0)
            {
                Wallet += 50;
            }
            else
            {
                string[] show1 = allLines.Intersect(words1, StringComparer.OrdinalIgnoreCase).ToArray();
                if (show1.Length > 0)
                {
                    Wallet += 20;
                }
                else {
                    Wallet += 10;
                }
                /*foreach (string result in show1)
                    Console.WriteLine("Kuch Ni H Bhai Ismein" + result);
                foreach (string result in show)
                { Console.WriteLine(result); }*/
            }
            try
            {
                cn.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["cn"].ToString();
                cn.Open();
                MySqlCommand cmd3 = cn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "update credits set wallet=?wallet where email=?email";
                cmd3.Parameters.Add(new MySqlParameter("wallet", Wallet));
                cmd3.Parameters.Add(new MySqlParameter("email", Session["user"].ToString()));
                cmd3.ExecuteNonQuery();
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