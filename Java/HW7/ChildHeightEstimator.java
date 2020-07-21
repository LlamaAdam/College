/****************************************
* ChildHeightEstimator.java
* <Adam Cox>
* 
* This is for 
****************************************/
import java.util.*;

public class ChildHeightEstimator
{
  Scanner stdIn = new Scanner(System.in);             // takes care of inputs
  String gender = "";                                 // Child's gender 
  String input = "";                                  // Used for input
  double measurement = 0.0;                           // Records height
  double dadMeasurement = 0.0;                        // Records Dad's height
  double momMeasurmenet = 0.0;                        // Records Mom's height
  int feet = 0;                                       // Records the feet
  double inches = 0;                                  // Record the inches

  //***************************************************************

  // Prompts the user to enter the gender
  
  public void promptForGender()
  {
    boolean valid = false;                              // Used for loops
    
    while (!valid)
    {
      System.out.print("Enter the child's gender (female/male): ");
      gender = stdIn.next().toLowerCase();
      if (gender.equals("male") || gender.equals("female"))
      {
        valid = true;
      }
      else
      {
        System.out.println("Invalid gender value. Must enter \"female\" or"
            + " \"male\": " + gender);
      }
    } // end while
  } // end of promptForGender
  
  //***************************************************************
  
  // records mother's height
  
  public void promptForMotherHeight()
  {
    momMeasurmenet=this.getHeight("mother's");
  } // end of promptForMotherHeight
  
  //***************************************************************
  
  // records father's height
  
  public void promptForFatherHeight()
  {
    dadMeasurement=this.getHeight("father's");
  } // end of promptForFatherHeight
  
  //***************************************************************
  
  // This displays child's height
  
  public void displayChildHeight()
  {
    measurement = (dadMeasurement+momMeasurmenet) / 2;
    if (gender.equals("male"))
    {
      measurement+=2.5;
    }
    else
    {
      measurement-=2.5;
    }
    feet = (int) (measurement / 12);
    inches = measurement - (feet * 12);
    System.out.println("The child's estimated height is "+ feet 
        +" feet, "+inches +" inches.");
  } // end of displayChildHeight
  
  //***************************************************************
  
  // Helper for getting height
  
  private double getHeight(String sex)
  {
    boolean valid = false;                              // Used for loops
    
    do
    {
      try 
      {
        System.out.println("Enter " + sex + " height in inches: ");
        input = stdIn.next();
        measurement = Double.parseDouble(input); 
        if (measurement >= 1)
        {
          valid = true;
        }
        else 
        {
          System.out.println("Invalid entry. Must be positive.");
        }
      }
      catch(NumberFormatException nfe)
      {
        System.out.println("Invalid entry. Must be a decimal number.");
      }
    } while (!valid);
    return measurement;
  } // end of loop
} // end of getHeight