using System;

namespace CourseGrader
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] testScores = new int[5] { 88, 97, 83, 48, 70 };

            string passFail = GradeTestScores(testScores);
            Console.WriteLine(passFail);
            Console.ReadLine();
        }

        public static string GradeTestScores(int[] testScores)
        {
            string pass;
            int sum = 0;
            if (testScores == null || testScores.Length == 0)
                return "fail";
            foreach (int score in testScores)
            {
                sum += score;
            }

            int average = sum / testScores.Length;
            if (average >= 70)
            {
                pass = "pass";
            }
            else if (average < 70)
            {
                pass = "fail";
            }
            else
            {
                pass = "fail";
            }
            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] < 50)
                    pass = "fail";
            }
            return pass;
        }
    }
}


        
      