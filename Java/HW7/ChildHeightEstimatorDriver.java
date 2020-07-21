/****************************************
* ChildHeightEstimatorDriver.Java
* <Adam Cox>
* 
* This is the driver for ChildHeightEstimator
****************************************/


public class ChildHeightEstimatorDriver
{
  public static void main(String[] args)
  {
    ChildHeightEstimator childHeight; // a child's height-calculation data  

    childHeight = new ChildHeightEstimator();
    childHeight.promptForGender();
    childHeight.promptForMotherHeight();
    childHeight.promptForFatherHeight();
    childHeight.displayChildHeight();
  } // end main
}  // end of ChildHeightEstimator