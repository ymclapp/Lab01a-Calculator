using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
      //do not declare any global variables
      //Main should output generic exceptions
      //Only define specific exceptions once and pay attention to the callstack on how requests are being made
      Console.WriteLine("Hello World!");
      StartSequence();
        }
    //getsum to add up numbers
    public static int[] GetSum()
    {
      int sum;
    }

    //getproduct to multiply numbers
    public static int GetProduct(int sum)
    {
      //variables
      int product, userNum;
      string userString;

      //get user info
      System.Console.WriteLine("Please enter to divide by and press enter:  ");
      userString = System.Console.ReadLine();
      userNum = System.Convert.ToInt32(userString);
      product = sum * userNum;

    }

    //getquotient to divide numbers
    public static double GetQuotient(int)
    }
}
