using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_JArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };

            //Accessing and display

            int element = matrix[0][1];


            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
                
            }

            Array.Resize(ref matrix[1], matrix[1].Length + 1);
            matrix[2][matrix[2].Length - 1] = 15;

            // Display the modified matrix
            Console.WriteLine("*****");
            Console.WriteLine("Displaying modified Matrix");
            foreach (int[] row in matrix)
            {
                foreach (int item in row)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }
            object[][] objectMatrix = new object[2][];
            objectMatrix[0] = new object[] { 12, "Hello", 4.25 };
            objectMatrix[1] = new object[] { true, 'A', DateTime.Now };


            for (int i = 0; i < objectMatrix.Length; i++)
            {
                for (int j = 0; j < objectMatrix[i].Length; j++)

                {
                    Console.WriteLine($"Type:{objectMatrix[i][j].GetType()}, value:{objectMatrix[i][j]}");


                }
                
            }
            Console.ReadKey();
        }
    }
}
