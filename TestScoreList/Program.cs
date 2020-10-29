using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScoreList1

{
    class Program
    {
        static void Main(string[] args)
        {   
            //Setting of testScores array to store 8 test scores; setting testscores & averagescores varible
            int[] testScores = new int[8];
            int totalScores = 0;
            double averageScores = 0;

            
            //Iterating 8 times and asking for input
             for (int i = 0; i < 8; i++)
            {
                Console.Write("Enter Exam Number " + i + "'s Grade here: ");
                testScores[i] = Convert.ToInt32(Console.ReadLine());
             }

            Console.WriteLine();
            Console.WriteLine("Your test score & the number of points you are from the average:");
            //Calculating the total sum of test scores
            for (int i = 0; i < 8; i++)
                totalScores += testScores[i];

            //Average test scores calculation
                averageScores = (double)totalScores / 8;

            //Dislaying how far is the test score formt he average
            for (int i = 0; i < 8; i++)
            {   
                double far = testScores[i] - averageScores;
                Console.WriteLine("Exam number " + i + "'s score was " + testScores[i] + ": Points from class average: " + far);
             }
            Console.WriteLine();

            //calculating the median & displaying to user
            Array.Sort(testScores);
            int middle = testScores.Length / 2;

            if (testScores.Length % 2 == 1)
                Console.WriteLine("The Median(middle) of the Exam scores is: " + testScores[middle]); 
            else
                Console.WriteLine("The Median(middle) of the Exam scores is: " +(testScores[middle - 1] + testScores[middle]) / 2.0); 
            

            //Displaying Mean to user
            Console.WriteLine("The Mean(average) of the Exam scores is: " + averageScores);
            Console.WriteLine();

        }

        

        




    }
}
