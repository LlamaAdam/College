/****************************************
* ExamScore.Java
* <Adam Cox>
* 
* This is for figuring out scores for exams.
****************************************/

public class ExamScore
{
  
  private static double combinedScored;
  private static int numOfExams;
  private static double lowestExam=0;
  private double singleExam;
  private static int maxPointsForEachExam;
  final private double A=0.9;
  final private double B=0.8;
  final private double C=0.7;
  final private double D=0.6;
  
  //*************************************************

  public ExamScore(double points)
  {
    numOfExams++;
    combinedScored+=points;
    singleExam=points;
    if(lowestExam == 0)
    {
      lowestExam=points;
    }
    if(points <= lowestExam)
    {
      lowestExam=points;
    }
  }
  
  public void setMaxPointsForEachExam(int max)
  {
    maxPointsForEachExam=max;
    
  }
  
  public int getNumOfExams()
  {
    return numOfExams;
    
  }
  public void printCombinedScore()
  {
    System.out.printf(
        "On all exams combined, you earned "+combinedScored+" out of "+maxPointsForEachExam*numOfExams
        +" possible points: "+this.grade(combinedScored,numOfExams)+"%n");
    
  }
  public void printScore()
  {
    System.out.printf(
        "On this exam, you earned "+singleExam+" out of "+maxPointsForEachExam
        +" possible points: "+this.grade(singleExam,1)+"%n");
    
  }
  public String grade(double score, int count)
  {
    double sum = (score/(maxPointsForEachExam*count));
    if(sum >= A)
    {
      return "A";
    }
    else if(sum >= B)
    {
      return "B";
    }
    else if(sum >= C)
    {
      return "C";
    }
    else if(sum >= D)
    {
      return "D";
    }
    else
    {
      return "F";
    }

  }
  
  public void printCombinedScoreWithLowestRemoved()
  {
    double lowScoreOut=combinedScored-lowestExam;
    int oneLessExam=numOfExams-1;
    System.out.printf(
        "On all exams combined, you earned "+lowScoreOut+" out of "+maxPointsForEachExam*oneLessExam
        +" possible points: "+this.grade(lowScoreOut,oneLessExam)+"%n");
  }
} //end class ExamScore
