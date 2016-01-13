using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(8);
            Console.ReadLine();
        }

        /// <summary>
        /// Print Pascal's Triangle
        /// </summary>
        /// <param name="rows">Number of rows to print</param>
        /// <seealso cref="https://en.wikipedia.org/wiki/Pascal%27s_triangle"/>
        public static void PrintTriangle(int rows)
        {
            int[] lastRow = { };

            for(int i = 1; i < rows + 1; i++)
            {
                int[] currentRow = new int[i];

                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write("{0, 3}", " ");
                }

                for(int j = 0; j < i; j++)
                {
                    int n = i;
                    int k = j;
                    
                    // we know the first and last columns are always one. 
                    // keeps indexes withing range
                    if (k == 0 || k == i - 1)
                        currentRow[j] = 1;
                    else
                        currentRow[j] = lastRow[k - 1] + lastRow[k];


                    Console.Write("{0, 6:D}", currentRow[j]);
                }

                Console.WriteLine("");

                lastRow = currentRow;
            }
        }

        /// <summary>
        /// Build jagged array containing Pascal's Triangle
        /// </summary>
        /// <param name="rows">numver of rows to geberate</param>
        /// <returns></returns>
        static int[][] Binomial(int rows)
        {
            int[][] triangle = new int[rows][];


            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new int[i+1];

                for (int j = 0; j <= i; j++)
                {
                    int n = i;
                    int k = j;

                    // we know the first and last columns are always one. 
                    // keeps indexes withing range
                    if (k == 0 || k == i)
                        triangle[i][j] = 1;
                    else
                        triangle[i][j] = triangle[i - 1][k - 1] + triangle[i - 1][k];


                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine("");
            }

            return triangle;
        }
    }
}
