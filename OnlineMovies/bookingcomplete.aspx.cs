using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineMovies
{
    public partial class bookingcomplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string number = (string)Session["usernumber"];
            string name = (string)Session["username"];
            string[] ticketNumber = (string[])Session["seatsbooked"];
            string moviename = (string)Session["moviename"];
            string seatbooked = "";
            for (int i = 0; i < 16; i++)
            {
                if (ticketNumber[i] == "B")
                {
                    seatbooked = (i+1)+","+seatbooked;
                }
            }
            Label1.Text = name;
            Label2.Text = number;
            Label3.Text = moviename;
            Label4.Text =   seatbooked.Remove(seatbooked.Length-1);

        }
    }
}