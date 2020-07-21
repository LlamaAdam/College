using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class home : System.Web.UI.Page
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
            userlog.Text += "Logged In User number ";
            userlog.Text += userid;
        }


    }
    public void entersite(Object Src, EventArgs E)
    {
        userbutton.Visible = false;
        panel2.Visible = true;
        panel4.Visible = true;

        string connectionString =
        "Data Source = teach-web01.park.edu\\mssqlser2;" +
         " Initial Catalog = acox_dbname;" +
         " Integrated Security = False;" +
         " User Id = acox_usn;" +
         " Password = W&k077fh;" +
         " MultipleActiveResultSets = True";

        connection = new SqlConnection(connectionString);
        try
        {
            // Try to open the connection.
            connection.Open();
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();

            command = new SqlCommand("SELECT * FROM content", connection);
            reader = command.ExecuteReader();
            lb2Names.DataSource = reader;
            lb2Names.DataTextField = "TitleOfMovie";
            lb2Names.DataValueField = "movieID";
            lb2Names.DataBind();
            reader.Close();


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
            lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
            lblInfo.Text += connection.State.ToString();
        }

    }


    public void Get_data(Object Src, EventArgs E)
    {
        panel2.Visible = true;
        panel4.Visible = false;
        panel5.Visible = true;
        string connectionString =
       "Data Source = teach-web01.park.edu\\mssqlser2;" +
        " Initial Catalog = acox_dbname;" +
        " Integrated Security = False;" +
        " User Id = acox_usn;" +
        " Password = W&k077fh;" +
        " MultipleActiveResultSets = True";
        connection = new SqlConnection(connectionString);

        try
        {


            connection.Open();
            lblInfo.Text = "<br /><b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            command = new SqlCommand("SELECT * FROM content  LEFT JOIN comment ON content.movieid = comment.movie_id WHERE movieid=@id", connection);
            command.Parameters.AddWithValue("@id", lb2Names.SelectedValue);

            reader = command.ExecuteReader();
            one_data.DataSource = reader;
            one_data.DataBind();
            reader.Close();
            int movieselc = Convert.ToInt32(lb2Names.SelectedValue);

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
            lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
            lblInfo.Text += connection.State.ToString();
        }
    } // end of get one data


    public void checkout(Object Src, EventArgs E)
    {
    try
        {
            // Try to open the connection.
            string connectionString =
         "Data Source = teach-web01.park.edu\\mssqlser2;" +
         " Initial Catalog = acox_dbname;" +
         " Integrated Security = False;" +
         " User Id = acox_usn;" +
         " Password = W&k077fh;" +
         " MultipleActiveResultSets = True";

            connection = new SqlConnection(connectionString);
            connection.Open();
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(7);
            string dateString = answer.ToString("MM-dd-yyyy");
            command = new SqlCommand("UPDATE content SET DateCheckedOut = @date, CheckedOut = 'y' WHERE movieid = @id", connection);
            command.Parameters.AddWithValue("@id", lb2Names.SelectedValue);
            command.Parameters.AddWithValue("@date", dateString);
            command.ExecuteNonQuery();
            command = new SqlCommand("INSERT INTO checkedout (movie_id, subscriber_id) VALUES (@movie, @subsriber)", connection);
            command.Parameters.AddWithValue("@movie", lb2Names.SelectedValue);
            int usernum =  0;
            usernum =Convert.ToInt32(Session["userid"]);
            command.Parameters.AddWithValue("@subsriber", usernum);
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
            lblInfo.Text += "<br /><b>Movie has been checked out.</b> ";
            //lblInfo.Text += connection.State.ToString();
            panel5.Visible = true;
        }

    }
}