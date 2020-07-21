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
        

    }
    
    public void content(object sender, EventArgs e)
    {
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
            data.DataSource = reader;
            data.DataBind();

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
    public void btnSubmit_edit_record(Object Src, EventArgs e)
    {
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
            data.DataSource = reader;
            data.DataBind();
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
    public void btnSubmit_delete_record(Object Src, GridViewDeleteEventArgs e)
    {
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
            int id = int.Parse(data.DataKeys[e.RowIndex].Value.ToString());

            connection.Open();
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();



            command = new SqlCommand("DELETE from content WHERE movieid=@id", connection);


            command.Parameters.AddWithValue("id", SqlDbType.Int).Value = id;

            command.ExecuteNonQuery();


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
            lblInfo.Text += "<br /><b>Delete was successfull</b> ";
            lblInfo.Text += connection.State.ToString();

        }
    }
    public void btnSubmit_update_record(Object Src, GridViewUpdateEventArgs e)
    {

    }

}