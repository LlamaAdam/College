using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class db : System.Web.UI.Page
{
    SqlConnection connection;
    SqlCommand command;
    SqlDataReader reader;

    public void Page_Load(object sender, EventArgs e)
    {
        int logged = 0;
        logged = Convert.ToInt32(Session["logger"]);
        string userid = " ";
        
        if (Session["userid"] != null)
        {
            userid = Session["userid"].ToString();
        }

        if (logged != 1)
        {
            Response.Redirect("index.aspx");

        }
        else
        {


        }


    }
    public void submit(Object Src, EventArgs E)
    {

        try
        {
            int moviechoice = Convert.ToInt32(Session["movieid"]);
            int usernum = 0;
            usernum = Convert.ToInt32(Session["userid"]);
            string connectionString =
                    "Data Source = teach-web01.park.edu\\mssqlser2;" +
                    " Initial Catalog = acox_dbname;" +
                    " Integrated Security = False;" +
                    " User Id = acox_usn;" +
                    " Password = W&k077fh;" +
                    " MultipleActiveResultSets = True";

            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand("INSERT INTO comment ( movie_id, subscriber_id, rating, comment)" +
                  " VALUES ( @movieid, @subscriber, @rating, @comment)", connection);
            command.Parameters.AddWithValue("@movieid", moviechoice);
            command.Parameters.AddWithValue("@subscriber", usernum);
            command.Parameters.AddWithValue("@rating", Rating.Text);
            command.Parameters.AddWithValue("@comment", review.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
        }
        finally
        {
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            connection.Close();
            lblInfo.Text = "<br /><b>Update was successfull</b> ";
            lblInfo.Text += connection.State.ToString();
            System.Threading.Thread.Sleep(5000);
            Response.Redirect("home.aspx");

        }


    }
    public void mainer(Object Src, EventArgs E)
    {
        Response.Redirect("home.aspx");
    }
}