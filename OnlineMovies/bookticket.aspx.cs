using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineMovies
{
    public partial class bookticket : System.Web.UI.Page
    {
        static string[] reserveTicket;
        static string[] rticket;
        static string[] selectedTicket;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                reserveTicket = new string[16];
                selectedTicket = new string[16];
                rticket = new string[16];
                for(int i=0;i<16;i++)
                {
                    rticket[i] = "A";
                }
                checkreservation();
            }
        }
        protected void checkreservation()
        {
            DataView moviesTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            string moviename = (string)Session["moviebooking"];
            moviesTable.RowFilter = string.Format("movie_id = '{0}'",moviename);
            DataRowView rowView = moviesTable[0];
            for(int i=0;i<reserveTicket.Length;i++)
            {
                string rowname = "seat"+(i + 1).ToString();
                reserveTicket[i] = rowView[rowname].ToString();
            }
            for (int i = 0; i < reserveTicket.Length; i++)
            {
                if (i == 0)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button1.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button1.BackColor = System.Drawing.Color.Red;
                        Button1.ToolTip = gettooltip(moviename,i+1);
                        Button1.Enabled = false;

                    }
                }
                if (i == 1)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button2.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button2.BackColor = System.Drawing.Color.Red;
                        Button2.ToolTip = gettooltip(moviename, i + 1);
                        Button2.Enabled = false;
                    }
                }
                if (i == 2)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button3.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button3.BackColor = System.Drawing.Color.Red;
                        Button3.ToolTip = gettooltip(moviename, i + 1);
                        Button3.Enabled = false;
                    }
                }
                if (i == 3)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button4.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button4.BackColor = System.Drawing.Color.Red;
                        Button4.ToolTip = gettooltip(moviename, i + 1);
                        Button4.Enabled = false;
                    }
                }
                if (i == 4)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button5.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button5.BackColor = System.Drawing.Color.Red;
                        Button5.ToolTip = gettooltip(moviename, i + 1);
                        Button5.Enabled = false;
                    }
                }
                if (i == 5)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button6.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button6.BackColor = System.Drawing.Color.Red;
                        Button6.ToolTip = gettooltip(moviename, i + 1);
                        Button6.Enabled = false;
                    }
                }
                if (i == 6)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button7.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button7.BackColor = System.Drawing.Color.Red;
                        Button7.ToolTip = gettooltip(moviename, i + 1);
                        Button7.Enabled = false;
                    }
                }
                if (i == 7)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button8.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button8.BackColor = System.Drawing.Color.Red;
                        Button8.ToolTip = gettooltip(moviename, i + 1);
                        Button8.Enabled = false;
                    }
                }
                if (i == 8)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button9.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button9.BackColor = System.Drawing.Color.Red;
                        Button9.ToolTip = gettooltip(moviename, i + 1);
                        Button9.Enabled = false;
                    }
                }
                if (i == 9)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button10.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button10.BackColor = System.Drawing.Color.Red;
                        Button10.ToolTip = gettooltip(moviename, i + 1);
                        Button10.Enabled = false;
                    }
                }
                if (i == 10)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button11.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button11.BackColor = System.Drawing.Color.Red;
                        Button11.ToolTip = gettooltip(moviename, i + 1);
                        Button11.Enabled = false;
                    }
                }
                if (i == 11)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button12.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button12.BackColor = System.Drawing.Color.Red;
                        Button12.ToolTip = gettooltip(moviename, i + 1);
                        Button12.Enabled = false;
                    }
                }
                if (i == 12)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button13.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button13.BackColor = System.Drawing.Color.Red;
                        Button13.ToolTip = gettooltip(moviename, i + 1);
                        Button13.Enabled = false;
                    }
                }
                if (i == 13)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button14.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button14.BackColor = System.Drawing.Color.Red;
                        Button14.ToolTip = gettooltip(moviename, i + 1);
                        Button14.Enabled = false;
                    }
                }
                if (i == 14)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button15.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button15.BackColor = System.Drawing.Color.Red;
                        Button15.ToolTip = gettooltip(moviename, i + 1);
                        Button15.Enabled = false;
                    }
                }
                if (i == 15)
                {
                    if (reserveTicket[i] == "A")
                    {
                        selectedTicket[i] = "A";
                        Button16.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        selectedTicket[i] = "B";
                        Button16.BackColor = System.Drawing.Color.Red;
                        Button16.ToolTip = gettooltip(moviename, i + 1);
                        Button16.Enabled = false;
                    }
                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (rticket[0] == "A")
            {
                Button1.BackColor = System.Drawing.Color.Green;
                rticket[0] = "B";

            }
            else
            {
                Button1.BackColor = System.Drawing.Color.Gray;
                rticket[0] = "A";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (rticket[2] == "A")
            {
                Button3.BackColor = System.Drawing.Color.Green;
                rticket[2] = "B";

            }
            else
            {
                Button3.BackColor = System.Drawing.Color.Gray;
                rticket[2] = "A";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (rticket[1] == "A")
            {
                Button2.BackColor = System.Drawing.Color.Green;
                rticket[1] = "B";

            }
            else
            {
                Button2.BackColor = System.Drawing.Color.Gray;
                rticket[1] = "A";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (rticket[3] == "A")
            {
                Button4.BackColor = System.Drawing.Color.Green;
                rticket[3] = "B";

            }
            else
            {
                Button4.BackColor = System.Drawing.Color.Gray;
                rticket[3] = "A";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (rticket[4] == "A")
            {
                Button5.BackColor = System.Drawing.Color.Green;
                rticket[4] = "B";

            }
            else
            {
                Button5.BackColor = System.Drawing.Color.Gray;
                rticket[4] = "A";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (rticket[5] == "A")
            {
                Button6.BackColor = System.Drawing.Color.Green;
                rticket[5] = "B";

            }
            else
            {
                Button6.BackColor = System.Drawing.Color.Gray;
                rticket[5] = "A";
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (rticket[6] == "A")
            {
                Button7.BackColor = System.Drawing.Color.Green;
                rticket[6] = "B";

            }
            else
            {
                Button7.BackColor = System.Drawing.Color.Gray;
                rticket[6] = "A";
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (rticket[7] == "A")
            {
                Button8.BackColor = System.Drawing.Color.Green;
                rticket[7] = "B";

            }
            else
            {
                Button8.BackColor = System.Drawing.Color.Gray;
                rticket[7] = "A";
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (rticket[8] == "A")
            {
                Button9.BackColor = System.Drawing.Color.Green;
                rticket[8] = "B";

            }
            else
            {
                Button9.BackColor = System.Drawing.Color.Gray;
                rticket[8] = "A";
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (rticket[9] == "A")
            {
                Button10.BackColor = System.Drawing.Color.Green;
                rticket[9] = "B";

            }
            else
            {
                Button10.BackColor = System.Drawing.Color.Gray;
                rticket[9] = "A";
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (rticket[10] == "A")
            {
                Button11.BackColor = System.Drawing.Color.Green;
                rticket[10] = "B";

            }
            else
            {
                Button11.BackColor = System.Drawing.Color.Gray;
                rticket[10] = "A";
            }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (rticket[11] == "A")
            {
                Button12.BackColor = System.Drawing.Color.Green;
                rticket[11] = "B";

            }
            else
            {
                Button12.BackColor = System.Drawing.Color.Gray;
                rticket[11] = "A";
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (rticket[12] == "A")
            {
                Button13.BackColor = System.Drawing.Color.Green;
                rticket[12] = "B";

            }
            else
            {
                Button13.BackColor = System.Drawing.Color.Gray;
                rticket[12] = "A";
            }
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (rticket[13] == "A")
            {
                Button14.BackColor = System.Drawing.Color.Green;
                rticket[13] = "B";

            }
            else
            {
                Button14.BackColor = System.Drawing.Color.Gray;
                rticket[13] = "A";
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            if (rticket[14] == "A")
            {
                Button15.BackColor = System.Drawing.Color.Green;
                rticket[14] = "B";

            }
            else
            {
                Button15.BackColor = System.Drawing.Color.Gray;
                rticket[14] = "A";
            }
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            if (rticket[15] == "A")
            {
                Button16.BackColor = System.Drawing.Color.Green;
                rticket[15] = "B";

            }
            else
            {
                Button16.BackColor = System.Drawing.Color.Gray;
                rticket[15] = "A";
            }
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            int i = 0;
            string moviename = (string)Session["moviebooking"];
            bool valid = false;
            for (i = 0; i < 16; i++)
            {

                if (rticket[i] == "B")
                {
                    valid = true;
                    string conn = "";
                    conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    SqlConnection objsqlconn = new SqlConnection(conn);
                    string updatedata = "Update seats_available set seat"+(i+1)+"='B' where movie_id=" + moviename;
                    string insertdata = "insert into user_details(movie_id,user_name,phone_number,seat_no) values("+moviename+",'"+TextBox1.Text+"','"+TextBox2.Text+"','"+(i+1)+"')";
                    objsqlconn.Open();
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd.CommandText = updatedata;
                    cmd1.CommandText = insertdata;
                    cmd.Connection = objsqlconn;
                    cmd1.Connection = objsqlconn;
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    objsqlconn.Close();
                }

            }
            if(valid==true)
            {
                Session["seatsbooked"] = rticket;
                Session["username"] = TextBox1.Text;
                Session["usernumber"] = TextBox2.Text;
                Response.Redirect("bookingcomplete.aspx");
            }
            else
            {
                Label3.Visible = true;
            }
            
        }

        protected string gettooltip(string movieId,int seatno)
        {
            string tooltip = "";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            string checkuser = "select * from user_details where movie_id="+ movieId +" and seat_no='"+seatno+"' ";
            SqlCommand cmd = new SqlCommand(checkuser, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
          
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {
                DataRow row = dt.Rows[0];
                string username = row["user_name"].ToString();
                string phonenumber = row["phone_number"].ToString();
                tooltip = username + ";" + phonenumber;
            }
            
            return tooltip;
        }
    }
}