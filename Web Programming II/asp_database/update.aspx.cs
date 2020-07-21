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
      public void btnSubmit_Click_seven(Object Src, EventArgs E)
    {
        
       panel2.Visible = false;
        panel3.Visible = true;
        panel1.Visible = false;
        panel4.Visible = true;
         panel7.Visible = true;

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

          // reader = command.ExecuteReader();
          //  data.DataSource = reader;
          //  data.DataBind();
           
            //reader.Close();
            
            reader = command.ExecuteReader();
            lb3Names.DataSource = reader;
            lb3Names.DataTextField = "last_name";
            lb3Names.DataValueField = "id";
            lb3Names.DataBind();
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
    public void btnSubmit_Click_one(Object Src, EventArgs E)
    {
        
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

          // reader = command.ExecuteReader();
          //  data.DataSource = reader;
          //  data.DataBind();
           
            //reader.Close();
            
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
            
            while (reader.Read())
    {
          txt2lastname.Text = (string) reader["last_name"];
          txt2firstname.Text = (string) reader["first_Name"];
          txt2city.Text = (string) reader["city"];
    }
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
    
public void btnSubmit_update_record(Object Src, EventArgs E)
    {  
       panel2.Visible = true;
        panel3.Visible = false;
        panel4.Visible = false;
        panel1.Visible = false;
        panel5.Visible = false;
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
           

            
      command = new SqlCommand("UPDATE people SET last_name=@lastname, first_name=@firstname, city=@city WHERE id=@id", connection);
   
          
          command.Parameters.AddWithValue("@id", lb2Names.SelectedValue);
          command.Parameters.AddWithValue("@lastname", txt2lastname.Text);
          command.Parameters.AddWithValue("@firstname", txt2firstname.Text);
          command.Parameters.AddWithValue("@city", txt2city.Text);

          
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
            panel5.Visible = false;
            panel6.Visible = true;
        }

    } // end of get one data

  public void Get_photo(Object Src, EventArgs E)
    {  
       panel2.Visible = false;
        panel3.Visible = false;
        panel4.Visible = false;
        panel1.Visible = false;
        panel5.Visible = false;
       panel8.Visible = true;


       
  }      
        
   protected void UploadButton_Click(object sender, EventArgs e)
{
    if(FileUploadControl.HasFile)
    {
        try
        {
            if(FileUploadControl.PostedFile.ContentType == "image/jpeg")
            {
                if(FileUploadControl.PostedFile.ContentLength < 102400)
                {
                    string filename = System.IO.Path.GetFileName(FileUploadControl.FileName);
                    FileUploadControl.SaveAs(Server.MapPath("~/asp_database/photo/") + filename);
                    string mapname = (Server.MapPath("~/asp_database/photo/") + filename);
                    
			 StatusLabel.Text = mapname;
				image_loc.Text = filename;
	
                   // StatusLabel.Text = "Upload status: File uploaded!";
                }
                else
                    StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
            }
            else
                StatusLabel.Text = "Upload status: Only JPEG files are accepted!";
        }
        catch(Exception ex)
        {
            StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
        }
    }
   }
}   
        
    
        
        
        
 