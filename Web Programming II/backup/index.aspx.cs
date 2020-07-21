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
    private int counter=0;
    
    
    public void Page_Load(object sender, EventArgs e)
    {
    if (Session["LoginAttempt"] == null)
        {
            Session["LoginAttempt"] = 0;
        }
    counter= Convert.ToInt32(Session["LoginAttempt"]);
    int logged = 0;

    }

    public void Login(object sender, EventArgs e)
    {
        login.Visible = true;
    }

    public void Search(object sender, EventArgs e)
    {
        search.Visible=true;
    }

    public void NewUse(object sender, EventArgs e)
    {
        newuse.Visible = true;
    }
    public void add_record(Object Src, EventArgs E)
    {

        newuse.Visible = true;
        
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



            command = new SqlCommand("INSERT INTO subscribers ( last_name, first_name, email_address, password)" +
                  " VALUES ( @last_name, @first_name, @email_address, @password)", connection);


            command.Parameters.AddWithValue("@last_name", last_name.Text);
            command.Parameters.AddWithValue("@first_name", first_name.Text);
            command.Parameters.AddWithValue("@email_address", email_address.Text);
            command.Parameters.AddWithValue("@password", password.Text);

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
            lblInfo.Text += "<br /><b>Record has been added</b> ";
            //lblInfo.Text += connection.State.ToString();
            panel5.Visible = true;
        }




    }

    public void Run_search(object sender, EventArgs e)
    {
        try
        {
            string connectionString =
        "Data Source = teach-web01.park.edu\\mssqlser2;" +
        " Initial Catalog = acox_dbname;" +
        " Integrated Security = False;" +
        " User Id = acox_usn;" +
        " Password = W&k077fh;" +
        " MultipleActiveResultSets = True";

        connection = new SqlConnection(connectionString);
        string find = "select TitleOFMovie, DateCheckedOut, CheckedOut,SmallDescript from Content where (TitleOFMovie like '%' + @search + '%')";
        SqlCommand trial = new SqlCommand(find, connection);
        trial.Parameters.Add("@search", SqlDbType.VarChar).Value = searchtext.Text;

        
            // Found this from a youtube video /watch?v=9e0kwADEoEg

            connection.Open();
            trial.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = trial;
            DataSet ds = new DataSet();
            da.Fill(ds, "TitleOFMovie");
            searchresult.DataSource = ds;
            searchresult.DataBind();
            connection.Close();
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text ="";
            lblInfo.Text = "Error reading the database. ";
            
            lblInfo.Text += err.Message;
        }
        finally
        {
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            connection.Close();
            lblInfo.Text ="";
            lblInfo.Text += "<br /><b>These are the results!</b> ";
            //lblInfo.Text += connection.State.ToString();
            panel5.Visible = true;
        }


    }
    public void loginbut(object sender, EventArgs e)
    {
        try 
//https://www.c-sharpcorner.com/article/how-to-create-login-page-in-asp-net-web-application-using-c-sharp-and-sql-server/
        {

            string connectionString =
                "Data Source = teach-web01.park.edu\\mssqlser2;" +
                " Initial Catalog = acox_dbname;" +
                " Integrated Security = False;" +
                " User Id = acox_usn;" +
                " Password = W&k077fh;" +
                " MultipleActiveResultSets = True";

            connection = new SqlConnection(connectionString);
            string uid= txusername.Text;
            string pass= txpassword.Text;
            string userid = string.Empty;
            connection.Open();
            string qry = "select * from subscribers where email_address='" + uid + "' and password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            using (SqlCommand cmdr = new SqlCommand(qry, connection))
        {
        // found on https://stackoverflow.com/questions/41882258/jut-get-as-result-system-data-sqlclient-sqldatareader
            SqlDataReader leitor = cmdr.ExecuteReader();

            while (leitor.Read())
            {
                string user = leitor["subscriber_id"].ToString();
                int Usernum = Convert.ToInt32(user);
                Session["userid"]= Usernum;
            }
        }
            
            SqlDataReader sdr = cmd.ExecuteReader();
            

        if(counter <= 3)
        {
        if (sdr.Read())
        {
        lblInfo.Text ="";
        lblInfo.Text = "Login Sucess......!!";
        Session["logger"]= 1;
        
        Response.Redirect("home.aspx");
        }
        else
        {
         lblInfo.Text ="";
        lblInfo.Text = "UserId & Password Is not correct Try again, you only have 3 attempts till account is locked!!";
        counter += 1;
        Session["LoginAttempt"]=counter;
        
        lblInfo.Text += "You have failed " + counter + " times.";
        
        }
            connection.Close();
        }
        else
        {
        lblInfo.Text ="You are locked out.";
        }
        }
        catch(Exception err)
        {
         lblInfo.Text ="";
        lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
        }
        


    }

}













