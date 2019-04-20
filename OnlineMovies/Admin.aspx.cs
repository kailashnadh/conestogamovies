using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineMovies
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] movie = new int[6];
            for(int i=0;i<movie.Length;i++)
            {
                movie[i] = i;
            }
            for(int i=0;i<movie.Length;i++)
            {
                string constring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(movie_id) FROM user_details where movie_id="+(i+1), con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        int num = Convert.ToInt32(cmd.ExecuteScalar());
                     
                           if(i==0)
                            {
                                Label3.Text = num.ToString();
                                Label2.Text = (16 - num).ToString();
                            }
                            if (i == 1)
                            {
                                Label6.Text = num.ToString();
                                Label5.Text = (16 - num).ToString();
                            }
                            if (i == 2)
                            {
                                Label9.Text = num.ToString();
                                Label8.Text= (16 - num).ToString();
                            }
                            if (i == 3)
                            {
                                Label12.Text = num.ToString();
                                Label11.Text = (16 - num).ToString();
                            }
                            if (i == 4)
                            {
                                Label15.Text = num.ToString();
                                Label14.Text = (16 - num).ToString();
                            }
                            if (i == 5)
                            {
                                Label18.Text = num.ToString();
                                Label17.Text = (16 - num).ToString();
                            }
                    }
                        con.Close();
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}