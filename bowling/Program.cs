using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = new int[] {  1, 4,  4,  5,  6, 4,  5, 5, 10, 0,  0, 1,  7, 3,  6, 4, 10, 0,  2,  8, 6 };
           // int[] input = new int[] { 10, 0, 10,  0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 10, 10};
            // int[] input = new int[] { 10, 0,  10,  0,  10, 0,  10, 0,  0, 0,  0, 0,  0, 0,  0, 0,  0, 0,  0,  0,  0};
             int[] input = new int[] { 0, 0,  0,  0,  0, 0,  0, 0,  0, 0,  0, 0,  0, 0,  0, 0,  10, 0,  10,  10,  10};

            int actualScore;
            Scoreboard scoreboard = new Scoreboard(input);
            actualScore = scoreboard.CalculateScore();
            Console.WriteLine("Total for the game :"+actualScore);
         
        }
      
    }
    
}
