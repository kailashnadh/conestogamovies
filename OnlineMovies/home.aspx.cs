using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineMovies
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void aquaman_Click(object sender, EventArgs e)
        {
            string movie = "2";
            string movieName = "Aquaman";
            bookMovie(movie,movieName);
        }

        protected void batman_Click(object sender, EventArgs e)
        {
            string movie = "1";
            string movieName = "Batman";
            bookMovie(movie,movieName);
        }

        protected void captain_Click(object sender, EventArgs e)
        {
            string movie = "4";
            string movieName = "Captain";
            bookMovie(movie,movieName);
        }

        protected void got_Click(object sender, EventArgs e)
        {
            string movie = "3";
            string movieName = "Game Of Thrones";
            bookMovie(movie,movieName);
        }

        protected void marvel_Click(object sender, EventArgs e)
        {
            string movie = "6";
            string movieName = "Marvel";
            bookMovie(movie,movieName);
        }

        protected void wonderwoman_Click(object sender, EventArgs e)
        {
            string movie = "5";
            string movieName = "WonderWoman";
            bookMovie(movie,movieName);
        }

        protected void bookMovie(string movieNumber,string movieName)
        {
            Session.Add("moviebooking",movieNumber);
            Session.Add("moviename", movieName);
            Response.Redirect("bookticket.aspx");
        }
    }
}