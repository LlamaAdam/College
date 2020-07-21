/****************************************
* EBook.java
* <Adam Cox>
* 
* This is for EBooks, subclass of Book.
****************************************/


private class EBook extends Book
{
  String purchaseLink;               // Site to get book.
  
  //***************************************************************
  
  private EBook(double price, String link)
  {
    super(price);
    this.purchaseLink = link;
  } // end constructor
  
  //***************************************************************
  
  private boolean equals(EBook otherBook)
  {
    return otherBook.purchaseLink == this.purchaseLink
        && otherBook.manufacturCost == this.manufacturCost;
  } // end equals
  
  //***************************************************************
  
  private void display()
  {
    System.out.printf("price = $%,.2f, url = \"%s\"\n",
        this.manufacturCost*.1, this.purchaseLink);
  } // end display
} // end EBook