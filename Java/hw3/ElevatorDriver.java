/****************************************
* ElevatorDriver.Java
* <Adam Cox>
* 
* This is the driver for Elevator
****************************************/

  import java.util.*;

  public class ElevatorDriver
  {
    public static void main(String[] args)
    {
      Scanner stdIn = new Scanner(System.in);
      int selection;  // Menu selection
      double weight;  // Weight of passenger
      boolean addPassengers = true; // allowed to add passengers

      Elevator elevatorOne = new Elevator(1000.0);

      System.out.println("Elevator has a " +
        Math.round(elevatorOne.MAX_LOAD) + " pound load limit.\n");

      while (addPassengers)
      {
        while (elevatorOne.isOverWeightLimit())
        {
          elevatorOne.display();
          System.out.print("Elevator is overloaded. " +
            "Who will take the stairs? ");
          selection = stdIn.nextInt();
          elevatorOne.removePassenger(selection);
          System.out.println();
        } // end while

        System.out.print("Input a weight in pounds of passenger" +
          " (0 to finish): ");
        weight = stdIn.nextDouble();

        if (weight == 0)
        {
          addPassengers = false;
        }
        else
        {
          elevatorOne.addPassenger(weight);
          System.out.println();
        }
      } // end while

      elevatorOne.display();
      System.out.println();
      elevatorOne.everyoneOut();
      elevatorOne.display();
    } // end main
  }