using System;
using System.Collections.Specialized;
using System.Diagnostics;

public class Array123JaggedExample
{
    public void TwoDArray()
    {
        Console.WriteLine("Enter the row");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the column");
        int col = int.Parse(Console.ReadLine());
        int [,] numbers = new int [row,col]; 

        Console.WriteLine("Enter the Element of arrays");
        for(int i=0;i< numbers.GetLength(0); i++) //row
        {
            for(int j=0; j< numbers.GetLength(1); j++)
            {
                numbers[i,j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ");
        }
        // Console.WriteLine("The Element of arrays are: ");
        // for(int i=0;i< numbers.GetLength(0); i++)
        // {
        //     for(int j=0; j< numbers.GetLength(1); j++)
        //     {
        //          Console.Write(numbers[i,j] + " ");
        //     }
        //     Console.WriteLine(" ");
        // }
        int count = 0;
        int colCount = numbers.GetLength(1);
        foreach (int item in numbers)
        {

            Console.Write(item + " ");
            count++;
            
            if(count % colCount == 0) Console.WriteLine();
        }
    }

    public void ThreeDArray()
    {
        Console.WriteLine("Enter the depth");
        int depth = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the row");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the column");
        int col = int.Parse(Console.ReadLine());
        int [,,] numbers = new int [depth,row,col]; 

        Console.WriteLine("Enter the Element of arrays");
        for(int d = 0; d < numbers.GetLength(0); d++)
        {
            for(int i=0;i< numbers.GetLength(1); i++)
            {
                for(int j=0; j< numbers.GetLength(2); j++)
                {
                    numbers[d, i,j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }
        
        Console.WriteLine("The Element of arrays are: ");
         for(int d = 0; d < numbers.GetLength(0); d++)
        {
            for(int i=0;i< numbers.GetLength(1); i++)
            {
                for(int j=0; j< numbers.GetLength(2); j++)
                {
                    Console.Write(numbers[d,i,j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }
    }

    public void Jagged1DArray()
    {
        // Enter the rows
        // 4
        // Enter number of elements for row 0: 1
        // Enter 1 elements for row 0:
        // Element [0][0] = 1

        // Enter number of elements for row 1: 2
        // Enter 2 elements for row 1:
        // Element [1][0] = 12
        // Element [1][1] = 1

        // Enter number of elements for row 2: 3
        // Enter 3 elements for row 2:
        // Element [2][0] = 1
        // Element [2][1] = 2
        // Element [2][2] = 3

        // Enter number of elements for row 3: 1
        // Enter 1 elements for row 3:
        // Element [3][0] = 2

        // Jagged Array Elements:
        // Row 0: 1 
        // Row 1: 12 1 
        // Row 2: 1 2 3 
        // Row 3: 2 
        Console.WriteLine("Enter the rows");
        int rows = int.Parse(Console.ReadLine());

        // Declare jagged array
        int[][] jaggedArray = new int[rows][];

        // Input elements for each row
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Enter number of elements for row {i}: ");
            int cols = int.Parse(Console.ReadLine());
 
            // Initialize the inner array
            jaggedArray[i] = new int[cols];

            Console.WriteLine($"Enter {cols} elements for row {i}:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i}][{j}] = ");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        // Display the jagged array
        Console.WriteLine("\nJagged Array Elements:");
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Row {i}: ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    public void Jagged2DArray()
    {
        Console.Write("Enter number of 2D arrays: ");
        int count = int.Parse(Console.ReadLine());

        // Declare jagged array of 2D arrays
        int[][,] jagged2D = new int[count][,];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\n 2D Array {i + 1} ");
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            // Initialize inner 2D array
            jagged2D[i] = new int[rows, cols];

            Console.WriteLine($"Enter {rows * cols} elements for 2D array {i + 1}:");

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"Element [{r},{c}] = ");
                    jagged2D[i][r, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Display all 2D arrays
        Console.WriteLine("\n Displaying Jagged 2D Arrays ");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\n2D Array {i + 1}:");
            for (int r = 0; r < jagged2D[i].GetLength(0); r++)
            {
                for (int c = 0; c < jagged2D[i].GetLength(1); c++)
                {
                    Console.Write(jagged2D[i][r, c] + "\t");
                }
                Console.WriteLine();
            }
        }   
    }
    public void Jagged3dArray()
    {
        Console.Write("Enter number of 3D arrays: ");
        int count = int.Parse(Console.ReadLine());

        // Declare jagged array of 3D arrays
        int[][,,] jagged3D = new int[count][,,];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\n 3D Array {i + 1} ");
            Console.Write("Enter number of depth: ");
            int depth = int.Parse(Console.ReadLine());
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            // Initialize inner 3D array
            jagged3D[i] = new int[depth ,rows, cols];

            Console.WriteLine($"Enter {depth * rows * cols} elements for 2D array {i + 1}:");
            for(int d = 0; d < depth; d++)
            {
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        Console.Write($"Element [{d},{r},{c}] = ");
                        jagged3D[i][d,r, c] = int.Parse(Console.ReadLine());
                    }
                }   
            }   
        }
        // Display all 3D arrays
        Console.WriteLine("\n Displaying Jagged 3D Arrays ");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\n3D Array {i + 1}:");
            for(int d = 0 ;d < jagged3D[i].GetLength(0); d++)
            {
                for (int r = 0; r < jagged3D[i].GetLength(1); r++)
                {
                    for (int c = 0; c < jagged3D[i].GetLength(2); c++)
                    {
                        Console.Write(jagged3D[i][d,r, c] + "\t");
                    }
                    Console.WriteLine();
                } 
                Console.WriteLine();  
            }
            
        }   
    }
    public void  DisplaySentence(params string[] sentence)
    {
        foreach(string n in sentence)
            Console.Write($" {n }");
    }
    public void CallDisplaySentence()
    {
        DisplaySentence("Hey", "Donkey!","Where","are","you?");
    }
    public int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
            total += n;
        return total;
    }
    public void CallParamSum(){
        Console.WriteLine(Sum());                // no argument
        Console.WriteLine(Sum(10));              // one argument
        Console.WriteLine(Sum(10, 20));          // two arguments
        Console.WriteLine(Sum(10, 20, 30, 40)); 
    }

    public double Average(params double[] nums)
    {
        double total = 0;
        foreach (double d in nums)
            total += d;
        return nums.Length > 0 ? total / nums.Length : 0;
    } 
    public void CallParamAverage(){
        Console.WriteLine("Average = " + Average(10.5, 20.5, 30.5));
    }

    //Exam questions
// 1. Develop a Cconsole application that calculates the annual bonus for three
// employees. The program should take the Employee Name and their Annual Salaryas input. The bonus is calculated based on years of service, which the user will
// also input.
// Use the following rules to determine the bonus percentage:
// Years of Service Bonus Percentage
// 1-2 years 5% of Salary
// 3-5 years 8% of Salary
// 6-10 years 12% of Salary
// More than 10 years 15% of Salary
    public void ExamQuestionFirstTerm2082()
    {
        // Jagged array: 3 employees, each with 3 fields
        // [Name, Salary, Years]
        string[][] employees = new string[3][];

        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = new string[3];
            Console.WriteLine($"\nEnter details for Employee {i + 1}:");
            
            Console.Write("Name: ");
            employees[i][0] = Console.ReadLine();

            Console.Write("Annual Salary: ");
            employees[i][1] = Console.ReadLine();

            Console.Write("Years of Service: ");
            employees[i][2] = Console.ReadLine();
        }

        Console.WriteLine("\n Annual Bonus Report ");

        for (int i = 0; i < employees.Length; i++)
        {
            string name = employees[i][0];
            double salary = Convert.ToDouble(employees[i][1]);
            int years = Convert.ToInt32(employees[i][2]);
            double bonusPercent;

            // Determine bonus percentage
            if (years >= 1 && years <= 2)
                bonusPercent = 0.05;
            else if (years >= 3 && years <= 5)
                bonusPercent = 0.08;
            else if (years >= 6 && years <= 10)
                bonusPercent = 0.12;
            else
                bonusPercent = 0.15;

            double bonus = salary * bonusPercent;
            double total = salary + bonus;

            Console.WriteLine($"\nEmployee: {name}");
            Console.WriteLine($"Salary: {salary:C}");
            Console.WriteLine($"Years of Service: {years}");
            Console.WriteLine($"Bonus ({bonusPercent * 100}%): {bonus:C}");
            Console.WriteLine($"Total with Bonus: {total:C}");
        }
    }

    //best way
    
}




