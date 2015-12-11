using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=10; i++)
            {
                for (int j=1; j<=10; j++)
                {
                    // Calculate the multiplication of the current cell:
                    int Result = i * j;
                    // Print it:
                    Console.Write(Result.ToString() + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
