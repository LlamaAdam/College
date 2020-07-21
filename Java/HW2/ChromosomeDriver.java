/****************************************
* ChromosomeDriver.Java
* <Adam Cox>
* 
* This program takes 3 chromesomes and changes some information in them
****************************************/

public class ChromosomeDriver
{
  public static void main(String[] args)
  {
    Chromosome c1, c2, c3; // chromosomes
    c1 = new Chromosome(new int[] {1, 2, 3, 4, 5, 6});
    c2 = new Chromosome(new int[] {11, 12, 13, 14, 15, 16});
    c3 = c1.replicate();
    c3.mutate();
    System.out.println("c3 = " + c3.getData());
    c1.crossover(c2);
    System.out.println("c1 = " + c1.getData());
    System.out.println("c2 = " + c2.getData());
  } // end main
} // end ChromosomeDriver


