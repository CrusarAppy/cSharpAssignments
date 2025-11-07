

using System;
using System.Dynamic;

class FunctionExample
{

    // set of instructions bundled in a unit to perform specific task
    void Addition()
    {
        int a, b, sum;
        a = 2;
        b = 6;
        sum = a + b;
    }
    // <access_specifier> <return_type> Method_Name()  
    // {  
    //     // block of code  
    // }  

    // Function with no Arguments and no return type
    // Function with Arguments and no return type.
    // Function with no Arguments and with a return type.
    // Functions with Arguments and with Return Type.
    public void FunctionNoArNoR()
    {
        Console.WriteLine("Hello");

    }
    public void CallFunction()
    {
        FunctionNoArNoR();
        //         Sum(1, "hello");
        //         int a = Multiply();
        //    Console.WriteLine(a);


    }
    // Function with 
    // Arguments and no return type.
    public void Sum(int a, String b)
    {
        String sum = a + b;
        Console.WriteLine(sum);

    }
    // Function with no Arguments and with a return type.

    public double Divide()
    {
        double a = 2;
        double b = 1;
        double divide = a / b;
        return divide;


    }
    public int Multiply()
    {

        return 2;
    }

    // Functions with Arguments and with Return Type.

    public String SayHello(String a)
    {
        String name = "bhatte";
        return a + name ;
     }

}