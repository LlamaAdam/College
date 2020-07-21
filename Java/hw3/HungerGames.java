/****************************************
* HGdriver.Java
* <Adam Cox>
* 
* This gets rid of all but one participant and claims them winner
****************************************/

  import java.util.*;

  public class HungerGames
  {
    public static void main(String[] args)
    {
      ArrayList<String> tributes = new ArrayList<>();

      tributes.add("Cato");
      tributes.add("Katniss");
      tributes.add("Peeta");
      tributes.add("Rue");

      HungerGames.play(tributes);
    } // end main

  //*************************************************************************
    
  //This gets rid of the other tributes  
    
    public static void play(ArrayList<String> tributes)
    {
      for(int i = 0; i <= tributes.size(); i++) //loop to remove tributes
      {
        int z= (int) (tributes.size() * Math.random());  //Random int
        
        tributes.remove(z);  
      } //end for loop
      
      System.out.print("This game is over, and the victor is "
      +tributes.get(0));
    }//end of play

  }

