/****************************************
* InsuranceHealth.java
* <Adam Cox>
* 
* This is for InsuranceHealth, subclass of InsurancePolicy.
****************************************/

public class InsuranceHealth extends InsurancePolicy
{
  private double deductible;      //Record the deductible.

  //*************************************************************************

  public InsuranceHealth(String name, double premiumValue, double deductibleValue)
  {
    super(name, premiumValue);
    this.deductible=deductibleValue;
  } // end of constructor
  
  //*************************************************************************  
  
  // This determines the changes to premium and deductible
  
  public double adjustCoverage(double deductibleChange)
  {
    double adjustmentValue = 0;                 //used for adjustment recording
    adjustmentValue=super.adjustCoverage(deductibleChange);
    deductible -= adjustmentValue*10;
    return adjustmentValue;
  } // end of adjustCoverage
  
  //*************************************************************************  
  
  // This displays the Insured's information

  public void display()
  {
    System.out.println("Health insurance policy holder: "+super.policyHolder);
    System.out.printf("Premium: $%,.2f\n"
        + "Deductible: $%,.2f\n",super.premium,this.deductible);
  } // end of display
} // end of InsuranceHealth