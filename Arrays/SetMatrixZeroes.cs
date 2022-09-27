namespace SetZero
{
    class SetMatrixzeroes
    {
        static void Main(string[] args)
        {
            int[,] inputArr = { { 1, 2, 0 }, { 1, 2, 3 }, { 1, 2, 4 } };
            SetZeroes(inputArr);
            Console.WriteLine("The final array is : ");
            for (int i = 0; i < inputArr.GetLength(0); i++)
            {
                for (int j = 0; j < inputArr.GetLength(1); j++)
                {
                    Console.Write(inputArr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void SetZeroes(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[] refRow = new int[rows];
            int[] refCol = new int[cols];
            Array.Fill<int>(refRow, -1);
            Array.Fill<int>(refCol, -1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        refRow[i] = 0;
                        refCol[j] = 0;
                    }
                }

            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (refRow[i] == 0 || refRow[j] == 0)
                    {
                        arr[i, j] = 0;
                    }
                }
            }
        }
    }
}
        /*
* 
*  static void Main(string[] args)
{
   int[,] inputArr = new int[4, 4];
   int[,] outputArr = new int[4, 4];
   int noRows, noColumns;
   noRows = Convert.ToInt32(Console.ReadLine());
   noColumns = Convert.ToInt32(Console.ReadLine());
   inputArr = GetInputArray(noRows, noColumns, inputArr);
   outputArr = SetMatrixZero(noRows, noColumns, inputArr);
   PrintArray(noRows, noColumns, outputArr);

}
private static void PrintArray(int rows, int cols, int[,] outputArr)
{
   for (int i = 0; i < rows; i++)
   {
       for (int j = 0; j < cols; j++)
       {
           Console.Write(outputArr[i,j]+ "  ");
       }
       Console.WriteLine();
   }
}

private static int[,] SetMatrixZero(int noRows, int noColumns, int[,] inputArr)
{
   int[,] newArr = new int[noRows, noColumns];
   Array.Copy(inputArr, newArr, noRows*noColumns);
   for (int i = 0; i < noRows; i++)
   {
       for (int j = 0; j < noColumns; j++)
       {
           if (inputArr[i,j] == 0)
           {
               SetRowColsZeroes(i, j, newArr, noRows, noColumns);
           }
       }
   }
   return newArr;

}

private static void SetRowColsZeroes(int row, int col, int[,] newArr, int rows, int cols)
{
   for(int i=0; i<rows; i++)
   {
       newArr[i, col] = 0;
   }
   for (int i = 0; i < cols; i++)
   {
       newArr[row, i] = 0;
   }

}

public static int[,] GetInputArray(int rows, int cols, int[,] arr)
{
   for(int i =0; i < rows; i++)
   {
       for(int  j = 0; j < cols; j++)
       {
           Console.Write("Enter Element" + (i + 1)+" , "+(j+1) + " : ");
           arr[i,j] = Convert.ToInt32(Console.ReadLine());
       }
   }
   return arr;
}
}*/
