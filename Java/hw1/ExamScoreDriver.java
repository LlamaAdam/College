/****************************************
* ExamScoreDriver.Java
* <Adam Cox>
* 
* This program is to look at the scores.
****************************************/

public class ExamScoreDriver
{
  
  
  public static void main(String[] args)
  {
    ExamScore exam1 = new ExamScore(70.5);
    ExamScore exam2 = new ExamScore(90);
    ExamScore exam3 = new ExamScore(79.5);
    ExamScore exam4 = new ExamScore(78);
    exam1.setMaxPointsForEachExam(100);
    exam1.printScore();
    exam2.printScore();
    exam3.printScore();
    exam4.printCombinedScore();
    exam4.printCombinedScoreWithLowestRemoved();

  }

} // end class ExamScoreDriver

