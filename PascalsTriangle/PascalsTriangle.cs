
using System;
using System.Collections;
namespace PascalsTriangleProject
{
    class PascalsTriangle
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no of rows");
            n = Convert.ToInt32(Console.ReadLine());
            int[][] triangle = new int[n][];
            for(int i = 0; i < n; i++)
            {
                triangle[i] = new int[i + 1];
                for(int j=0; j<i+1; j++)
                {
                    if(j==0|| j==i) triangle[i][j] = 1;
                    else
                    {
                        if (i != 0)
                        {
                            triangle[i][j] = triangle[i - 1][j-1] + triangle[i - 1][j];
                        }
                    }
                }
            }

            //Print the array
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write(triangle[i][j] + " ") ;
                }
                Console.WriteLine();
            }

            


        }
    }
}