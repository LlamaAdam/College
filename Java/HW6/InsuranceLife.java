/****************************************
* InsuranceLife.java
* <Adam Cox>
* 
* This is for InsuranceLife, subclass of InsurancePolicy.
****************************************/
import java.util.*;

public class InsuranceLife extends InsurancePolicy
{
  private double deathBenefit;                               // For Death Benefits
  ArrayList<String> beneficiaries = new ArrayList<String>(); // For Those that receive money

  //*************************************************************************

  public InsuranceLife(String name, double premiumValue, double deathPayday)
  {
    super(name, premiumValue);
    this.deathBenefit = deathPayday;
  } // end of constructor
  
  //*************************************************************************  
  
  // This determines the changes to premium and benefit

  public double adjustCoverage(double premiumChange)
  {
    double adjustmentValue = 0;
    adjustmentValue = super.adjustCoverage(premiumChange);
    deathBenefit += premiumChange*10000;
    return adjustmentValue;
  } // end of adjustCoverage
  
  //*************************************************************************  
  
  // This displays the Insured's information

  public void display()
  {
    System.out.println("Life insurance policy holder: "+super.policyHolder);
    System.out.printf("Premium: $%,.2f\n"
        + "Death benefit: $%,.2f\n",super.premium,this.deathBenefit);
    System.out.println("Beneficiaries:");
    for (String receiver : beneficiaries)
    {
      System.out.println(receiver);
    } // end of display
  } // end of InsuranceLife
  
  //*************************************************************************  
  
  // This adds a beneficiary

  public void addBeneficiary(String moneyReceiver)
  {
    beneficiaries.add(moneyReceiver);
  } // end of addBeneficiary
  
} // end of InsuranceLife