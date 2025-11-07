//Write a program in cto create an array of string which takes string as input from the user and displays all the array elements.

using System;
using System.Data;

public class ArrayExample
{
    public void displayArray()
    {
        // Console.WriteLine("Enter how many element do you want to store in array");

        // int size = int.Parse(Console.ReadLine());
        string[] arrayString = { "ee", "wer", "ere" };
        Console.WriteLine("Enter the elements of array");
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayString[i] = Console.ReadLine();
        }
        //display array
        Console.WriteLine("Array elements are:");
        foreach (string element in arrayString)
        {
            Console.WriteLine(element);
        }
    }
    public void doubleArrayRepresentation()
    {
        Console.WriteLine("Enter the row");
        int row = int.Parse(Console.ReadLine());
        double [] decimalNumbers = new double[row];

        Console.WriteLine("Enter the elements od the array");
        for(int i =0; i < decimalNumbers.Length; i++)
        {
            decimalNumbers[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Element of the array are");

        for(int i =0; i < decimalNumbers.Length; i++)
        {
            Console.WriteLine(decimalNumbers[i]);
        }
        // foreach(double number in decimalNumbers)
        // {
        //     Console.WriteLine(number);
        // }

    }
}