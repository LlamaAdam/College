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
        
       panel2.Visible = true;
        panel3.Visible = true;
        panel1.Visible = false;
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
    } // end of button click one
    
    public void Get_data(Object Src, EventArgs E)
    {  
       panel2.Visible = true;
        panel3.Visible = false;
        panel4.Visible = false;
        panel1.Visible = false;
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
            // Try to open the connection.
            connection.Open();
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
            
            command = new SqlCommand("SELECT * FROM content WHERE Movieid=@id", connection);
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
    } // end of get one data

    
         public void btnSubmit_update_record(Object Src, GridViewUpdateEventArgs e)
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
            int id=int.Parse(data.DataKeys[e.RowIndex].Value.ToString());
            
            connection.Open();
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
           

            
      command = new SqlCommand("UPDATE content SET TitleOfMovie=@lastname, SmallDescript=@firstname, DateCheckedOut=@city WHERE SmallDescript=@id", connection);
    //command = new SqlCommand("UPDATE people SET last_name=@lastname  WHERE id=@id", connection);
          
          //command.Parameters.AddWithValue("@id", data.Rows[0]["id"]).Text.ToString();
            
          command.Parameters.AddWithValue("@id",                           
                              ((TextBox)data.Rows[e.RowIndex].Cells[0].Controls[0]).Text.ToString());  
            
            
         command.Parameters.AddWithValue("@lastname", 
           ((TextBox)data.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString());  
          command.Parameters.AddWithValue("@firstname",
           ((TextBox)data.Rows[e.RowIndex].Cells[1].Controls[0]).Text.ToString());  
          command.Parameters.AddWithValue("@city", 
               ((TextBox)data.Rows[e.RowIndex].Cells[3].Controls[0]).Text.ToString());  
          
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
            lblInfo.Text += "<br /><b>Update was successfull</b> ";
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
 		int id=int.Parse(data.DataKeys[e.RowIndex].Value.ToString());

            connection.Open();
            lblInfo.Text = "<b>Server Version:</b> " + connection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + connection.State.ToString();
           

            
      command = new SqlCommand("DELETE from people WHERE id=@id", connection);
   
          
          //command.Parameters.AddWithValue("@id", lb2Names.SelectedValue);
          command.Parameters.AddWithValue("id", SqlDbType.Int).Value = id;
        //  command.Parameters.AddWithValue("@id",                           
                            //  ((TextBox)data.Rows[e.RowIndex].Cells[0].Controls[0]).Text.ToString());  

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
    
        
        
        
  }//
}