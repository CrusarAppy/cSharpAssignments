using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello ");

        int number1, number2, sum, subtract;
        Console.WriteLine("Enter a number");
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number");
        number2 = int.Parse(Console.ReadLine());

        ArithmeticOperation operation = new ArithmeticOperation();
        sum = operation.Add(number1, number2);
        // sum = Program.Add(number1, number2);
        // Console.WriteLine("The sum of two number is " + sum);

          subtract =operation.Subtract(number1, number2);
        Console.WriteLine("The Difference of two number is " + subtract);
    }
     public  static int Add(int a, int b)
    {
       
        return a + b;
    }
}