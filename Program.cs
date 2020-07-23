using System;
//using 
namespace Assignment
{

    class Program
    {
        static Boolean GridSearch(int[,] Grid, int[,] gridCheck)
        {
            bool found = true;
            for (int dRow = 0; dRow < Grid.GetLength(0) - gridCheck.GetLength(0); dRow++)
            {
                for (int dCol = 0; dCol < Grid.GetLength(1) - gridCheck.GetLength(1); dCol++)
                {
                    

                    for (int fRow = 0; fRow < gridCheck.GetLength(0); fRow++)
                    {
                        for (int fCol = 0; fCol < gridCheck.GetLength(1); fCol++)
                        {
                            if (Grid[dRow + fRow, dCol + fCol] != gridCheck[fRow, fCol])
                            {
                                found = false;
                                break;
                            }
                        }

                        //if (!found) break;
                    }

                   // if (found) return true;
                }
            }

            return found;
        }
        static void Main(string[] args)
        {
            int test = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(test);
            for (int i = 1; i <= test; i++)
            {
                string arrayArea = Console.ReadLine();
                string[] split = arrayArea.Split(" ");
                int row = Convert.ToInt32(split[0]);
                int column = Convert.ToInt32(split[1]);
                int[,] array = new int[row,column];
                for( int r=0; r<row; r++)
                    for (int c = 0; c < column; c++)
                        array[r,c]= Convert.ToInt32(Console.ReadLine());

                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < column; c++)
                    { 
                        Console.Write(array[r, c] + " "); 
                    }
                    Console.WriteLine();
                }

                        
                string arrayArea1 = Console.ReadLine();
                string[] split2 = arrayArea1.Split(" ");
                int row1 = Convert.ToInt32(split2[0]);
                int column1 = Convert.ToInt32(split2[1]);
                int[,] array1 = new int[row, column];
                for (int r = 0; r < row1; r++)
                    for (int c = 0; c < column1; c++)
                        array1[r, c] = Convert.ToInt32(Console.ReadLine());

                for (int r = 0; r < row1; r++)
                {
                    for (int c = 0; c < column1; c++)
                    {
                        Console.Write(array1[r, c] + " ");
                    }
                    Console.WriteLine();
                }

                Boolean result = GridSearch( array, array1);
                string S = result ? "YES" : "NO";
                Console.WriteLine(S);
            }
        }
    }
}
