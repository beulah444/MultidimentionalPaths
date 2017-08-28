using System;

class Program
{
    static void Main()
    {
        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine("The paths are:");
        PrintAllPathIn2DArray p = new PrintAllPathIn2DArray(a);
        p.printAll(0, 0, "");
    Console.WriteLine("Number of paths to the bottom - right of the cell in the given 2D array = {0}",
                      numberOfPaths(a.GetLength(0),a.GetLength(1)));
        Console.ReadKey();
    }
    // Returns count of possible paths to reach 
    // cell at row number m and column number n 
    // from the topmost leftmost cell (cell at 1, 1)
    static int numberOfPaths(int m, int n)
    {
        // If either given row number is first or 
        // given column number is first
        if (m == 1 || n == 1)
            return 1;

        // If diagonal movements are allowed then 
        // the last addition is required.
        return numberOfPaths(m - 1, n) + numberOfPaths(m, n - 1);
        // + numberOfPaths(m-1,n-1);
    }
}
public class PrintAllPathIn2DArray
{

    public int count = 0;
    int rowCount;
    int colCount;
    int[,] arrA;

    public PrintAllPathIn2DArray(int[,] arrA)
    {
        this.arrA = arrA;
        rowCount = arrA.GetLength(0);
        colCount = arrA.GetLength(1);
    }

    public void printAll(int currentRow, int currentColumn, String path)
    {
        if (currentRow == rowCount - 1)
        {
            for (int i = currentColumn; i < colCount; i++)
            {
                path += "-" + arrA[currentRow, i];
            }
            Console.WriteLine(path);
            return;
        }
        if (currentColumn == colCount - 1)
        {
            for (int i = currentRow; i <= rowCount - 1; i++)
            {
                path += "-" + arrA[i, currentColumn];
            }
            Console.WriteLine(path);
            return;
        }
       
        path = path + "-" + arrA[currentRow, currentColumn];
       
        printAll(currentRow + 1, currentColumn, path);
        printAll(currentRow, currentColumn + 1, path);

        //	printAll(currentRow + 1, currentColumn + 1, path);
     
    }
   
}
