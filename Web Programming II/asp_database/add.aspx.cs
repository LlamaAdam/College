using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class db : System.Web.UI.Page
{
    SqlConnection connection;
    SqlCommand command;
    SqlDataReader reader;

    
    
    protected void Page_Load(object sender, EventArgs e)
    {
   

    }
    
    
   


    public void btnSubmit_Click_one(Object Src, EventArgs E)
    {
       /* 
       panel2.Visible = true;
        panel3.Visible = true;
        panel1.Visible = false;
        panel4.Visible = true;
        
        string connectionString =
        "Data Source = teach-web01.park.edu\\MSSQLSER2;" +
      " Initial Catalog = db1;" +
      " Integrated Security = False;" +
      " User Id = mlong;" +
      " Password = Vem5o7&0;" +
      " MultipleActiveResultSets = True";

        connection = new SqlConnection(connectionString);
        try
        {
            // Try to open the connection.
            connection.Open();
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            
            command = new SqlCommand("SELECT * FROM people", connection);

           reader = command.ExecuteReader();
            data.DataSource = reader;
            data.DataBind();
           
            reader.Close();
            
            reader = command.ExecuteReader();
            lb2Names.DataSource = reader;
            lb2Names.DataTextField = "last_name";
            lb2Names.DataValueField = "id";
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
        */
    } // end of button click one
    
    public void Get_data(Object Src, EventArgs E)
    {  
      /*
        panel2.Visible = true;
        panel3.Visible = false;
        panel4.Visible = false;
        panel1.Visible = false;
      //  panel5.Visible = true;
        string connectionString =
        "Data Source = teach-web01.park.edu\\MSSQLSER2;" +
      " Initial Catalog = db1;" +
      " Integrated Security = False;" +
      " User Id = mlong;" +
      " Password = Vem5o7&0;" +
      " MultipleActiveResultSets = True";

        connection = new SqlConnection(connectionString);
        try
        {
            // Try to open the connection.
            connection.Open();
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            
            command = new SqlCommand("SELECT * FROM people WHERE id=@id", connection);
            command.Parameters.AddWithValue("@id", lb2Names.SelectedValue);

           
            
           
            reader = command.ExecuteReader();
            one_data.DataSource = reader;
            one_data.DataBind();
            

    
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
      */  
    } // end of get one data
// begining of add button
    
      public void add_record(Object Src, EventArgs E)
    {  
      Response.Write("you have connected to your .cs page add records");   
     panel2.Visible = true;
          string connectionString =
           "Data Source = teach-web01.park.edu\\MSSQLSER2;" +
           " Initial Catalog = db1;" +
           " Integrated Security = False;" +
           " User Id = mlong;" +
           " Password = Vem5o7&0;" +
           " MultipleActiveResultSets = True";

        connection = new SqlConnection(connectionString);
        try
        {
            // Try to open the connection.
            connection.Open();
            
            
                
            //lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
           // lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            
            
            
            
            command = new SqlCommand("INSERT INTO people (id, last_name, first_name, address, city, state)" +
                  " VALUES (@id, @lastname, @firstname, @address, @city, @state)", connection);
   
          
          command.Parameters.AddWithValue("@id", id.Text);
          command.Parameters.AddWithValue("@lastname", last_name.Text);
          command.Parameters.AddWithValue("@firstname", first_name.Text);
          command.Parameters.AddWithValue("@address", address.Text);
          command.Parameters.AddWithValue("@city", city.Text);
          command.Parameters.AddWithValue("@state", state.Text);
          
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
        
    
        
        
        
 
}