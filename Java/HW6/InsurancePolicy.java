/****************************************
* InsurancePolicy.java
* <Adam Cox>
* 
* This is for the class InsurancePolicy.
****************************************/

public abstract class InsurancePolicy
{
  protected String policyHolder;          // Policy Holder's Name
  protected double premium = 0;           // Premium for adjustment
  public abstract void display();
  
  //*************************************************************************
  
  public InsurancePolicy(String name, double premiumValue)
  {
    this.policyHolder = name;
    this.premium = premiumValue;
  } // end of constructor
  
  //*************************************************************************  
  
  // This determines premium changes.
  
  public double adjustCoverage(double premiumChange)
  {
   if((premium+premiumChange)>10) // If premium changes are above minimum
   {
     premium+=premiumChange;
     return premiumChange;
   }
   else                           // else premium changes are below minimum
   {
     double oldPremium=premium;   // Stores the old Premium for adjustment
     premium=10;
     return 10-oldPremium;
   }
  } // end of adjustCoverage
} // end of InsurancePolicy