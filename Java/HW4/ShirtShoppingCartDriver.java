/****************************************
* ShirtShoppingCartDriver.Java
* <Adam Cox>
* 
* This is the driver for ShirtShoppingCart
****************************************/

 import java.util.*;

public class ShirtShoppingCartDriver
{
  public static void main(String args[])
  {
    Scanner stdIn = new Scanner(System.in);
    int selection; // user selected shirt
    String[] shirts = new String[] {
      "Make America Great Again", "Build the Wall!",
      "Drain the Swamp", "I like Liz!",
      "I've got a plan for that", "Medicare for All"
    };
        
    ShirtShoppingCart sc = new ShirtShoppingCart();
        
    System.out.printf(
      "UNCLE SAM'S SHIRT SHOP\u2122\n\n" +
      "All shirts are $%.2f each, but today only, large" +
      " and extra-large shirts are on sale for $%.2f.\n",
      ShirtShoppingCart.STANDARD_PRICE,
      ShirtShoppingCart.SALE_PRICE);
    System.out.println("Here are the shirts:");
        
    // Display the shirts
    for (int i=0; i<shirts.length; i++)
    {
      System.out.println(i+1 + ") " + shirts[i]);
    }
        
    do
    {
      System.out.print("\nTo select a shirt, enter 1-" +
        shirts.length + " (0 to checkout): ");
      selection = stdIn.nextInt();
          
      if (selection < 0 || selection > shirts.length)
      {
        System.out.println("Invalid input.");
      }
      else if (selection != 0)
      {
        sc.addToCart(shirts[selection-1]);
      }
    } while (selection != 0);
      
    sc.checkOut();
  } // end main

}