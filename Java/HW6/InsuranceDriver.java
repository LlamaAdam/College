/****************************************
* InsuranceDriver.Java
* <Adam Cox>
* 
* This is the driver for Insurance
****************************************/
import java.util.*;

public class InsuranceDriver
{
  public static void main(String[] args)
  {
    InsuranceLife lifePolicy;     // holds a life insurance policy
    InsuranceHealth healthPolicy; // holds a health insurance policy
    double actualAdjustment;      // actual amount adjusted for premium
      
    // Array of insurance policies, to be filled with both types
    InsurancePolicy[] policies = new InsurancePolicy[50];

    lifePolicy = new InsuranceLife("John Dean", 40, 400000);
    lifePolicy.addBeneficiary("Caiden Dean");
    lifePolicy.addBeneficiary("Jordan Dean");
    lifePolicy.adjustCoverage(+10);
    policies[0] = lifePolicy;
      
    healthPolicy = new InsuranceHealth("John Dean", 500, 2000);
    healthPolicy.adjustCoverage(+100);
    policies[1] = healthPolicy;

    healthPolicy = new InsuranceHealth("Taylor Swift", 600, 1000);
    actualAdjustment = healthPolicy.adjustCoverage(-700);
    System.out.println("Actual premium adjustment = " + actualAdjustment);
    policies[2] = healthPolicy;
      
    for (int i=0; i<policies.length && policies[i] != null; i++)
    {
      policies[i].display();
      System.out.println();
    }
  } // end main

} // end of InsuranceDriver