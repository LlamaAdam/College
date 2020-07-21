/****************************************
* PaperBook.java
* <Adam Cox>
* 
* This is for Paperbooks, subclass of Book.
****************************************/


public class PaperBook extends Book
{
  double bookWeight = 0;              // Books Weight
  
  //***************************************************************
  
  public PaperBook(double price, double weight)
  {
    super(price);
    this.bookWeight = weight;
  } // end constructor
  
  //***************************************************************
  
  public boolean equals(PaperBook otherBook)
  {
    return otherBook.bookWeight == this.bookWeight
        && otherBook.manufacturCost == this.manufacturCost;
  } // end equals
  
  //***************************************************************
  
  public void display()
  {
    System.out.printf("price = $%,.2f, weight = %,.1f",
        this.manufacturCost*this.bookWeight, this.bookWeight);
  } // end display
} // end PaperBook