/****************************************
* Elevator.Java
* <Adam Cox>
* 
* This program adjust the weights of passengers and gives an alert.
****************************************/

  import java.util.*;

  public class Elevator
  {
    public final double MAX_LOAD;        //This set the max weight
    public double combinedWeight = 0;    //This is the passenger weight
    public ArrayList<Double> passengerWeights = new ArrayList<>(); //Each Passenger Weight
    
    //*************************************************************************
    
    public Elevator(double weight)
    {
      MAX_LOAD = weight;
    } // end constructor
    
    //*************************************************************************  
    
    // This determines if the elevator is over the weight limit.
    
    public boolean isOverWeightLimit()
    {
        return (combinedWeight > MAX_LOAD);     
    } // end isOverWeightLimit
    
    //*************************************************************************
    
    // This adds a passenger weight to the arraylist and combined
    
    public void addPassenger(double body)
    {
      System.out.print("A "+ body + " passenger entered the elevator.\n");
      passengerWeights.add(body);
      combinedWeight += body;
      if (combinedWeight > MAX_LOAD)
      {
        System.out.print("Warning! The elevator has surpassed its maximum "
            + "weight capacity of "+ MAX_LOAD +" pounds.\n");
      }
    } // end addPassenger
    
    //*************************************************************************
    
    // This removes the passenger selected
    
    public void removePassenger(int person)
    {
      int personIndex = person - 1;       // Subtract 1 from user input
      
      if (person >=1 && person <=passengerWeights.size())
      {
        combinedWeight -= passengerWeights.get(personIndex);
        System.out.print("A "+ passengerWeights.get(personIndex) + " pound passenger"
              + " has left the elevator.\n");
        passengerWeights.remove(personIndex);
      }
      else 
      {
        System.out.print("Error! Invalid selection.\n");
      }
    } // end removePassenger
    
    //*************************************************************************
    
    // Removes everyone from the Elevator.
    
    public void everyoneOut()
    {
      passengerWeights.clear();
      combinedWeight = 0;
      System.out.print("All the passengers have exited.\n");
    } // end everyoneOut
    
    //*************************************************************************
    
    // Displays the weight of each person
    
    public void display()
    {
      if (combinedWeight == 0)
      {
        System.out.print("There are currently no passengers left on the elevator.");
      }
      else
      {
        System.out.print("Here are the passenger weights:\n");
        for (int i = 0; i< passengerWeights.size(); i++) //displays weights
        {
          System.out.printf(i+1 + ") " +passengerWeights.get(i)+ "\n");
        }
      }
    } // end display
    
  } // end elevator