/****************************************
* ShirtShoppingCart.Java
* <Adam Cox>
* 
* This program adds a selected shirt and allows user to select size.
****************************************/

import java.util.*;

public class ShirtShoppingCart
{ 
  public enum Size
  {
    SMALL, MEDIUM, LARGE, EXTRA_LARGE
  }   // Sizes of Shirts
  public final static double STANDARD_PRICE = 10.00;            // S&M Shirt price
  public final static double SALE_PRICE = 5.00;                 // L&XL SHirt Price
  private ArrayList<String> shirts = new ArrayList<>();  // List of shirts purchased
  private double totalcost = 0.00;                       // Cost of all shirts
  
  //*************************************************************************
 
  // adds shirt design, size and cost
  
  public void addToCart(String shirtTitle)
  {
    Size sizer;             // Gets Shirt size
    
    sizer = getShirtSize();    
    shirts.add(shirtTitle);
    
    switch (sizer)          // Shows shirts size & adds to cart
    {
      case SMALL: case MEDIUM:
        System.out.println("Your shirt size is: " + sizer);
        totalcost += STANDARD_PRICE;
        break;
      case LARGE: case EXTRA_LARGE:
        System.out.println("Your shirt size is: " + sizer);
        totalcost += SALE_PRICE;
        break;
     } // end of switch
    
    System.out.println("\"" + shirtTitle + "\" added to your cart.");
  } // end of addToCart
  
  //*************************************************************************
  
  // Helper that returns shirt size
  
  public Size getShirtSize()
  {
    Scanner stdIn = new Scanner(System.in);
    int selectSize;  // User selected size
    
    System.out.print("Enter chest measurement of the person the shirt is for: ");
    selectSize = stdIn.nextInt();
    if (selectSize >= 42)
    {
      return Size.EXTRA_LARGE;
    }
    else if (selectSize >= 40)
    {
      return Size.LARGE; 
    }
    else if (selectSize >= 38)
    {
      return Size.MEDIUM;
    }
    else
    {
      return Size.SMALL;
    }
  } // end of getShirtSize
  
  //*************************************************************************
 
  // This runs a checkout
  
  public void checkOut()
  {
    if (totalcost == 0.0)
    {
      System.out.println("Thanks for checking out our site.\u2764");
    }
    else
    {
      System.out.println("You selected:\n");
      for (String shirt : shirts)       // Displays shirt's writing
      {
        System.out.println(shirt);
      }
      System.out.printf("-".repeat(28) + "\nYour total is: $%,.2f%n\nThank you for "
          + "shopping at Uncle Sam's Shirt Shop\u2122!", totalcost);
    } // end else
  } // end of checkOut
} // end of ShirtShoppingCart