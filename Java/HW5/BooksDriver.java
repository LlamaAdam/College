/****************************************
* BooksDriver.java
* <Adam Cox>
* 
* This is the driver for Books.
****************************************/


public class BooksDriver
{
  public static void main(String[] args)
  {
    EBook eBook1 =
      new EBook(52.80, "www.books.com/TheHandmaidsTale.pdf");
    EBook eBook2 =
      new EBook(52.80, "www.books.com/TheHandmaidsTale.pdf");
    if (eBook1.equals(eBook2))
    {
      eBook1.display();
    }

    PaperBook paper1 = new PaperBook(60, 2);
    PaperBook paper2 = new PaperBook(60, 2.0);
    if (paper1.equals(paper2))
    {
      paper1.display();
    }
  } // end main
} // end class BookDriver