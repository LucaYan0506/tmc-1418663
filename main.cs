using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        /*
        string[] months = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Now","Dec"};

        for (int i = 0; i < 100; i++){
          Random rnd = new Random();

          int month = rnd.Next(0,12);

          Console.WriteLine("Month is {0}",months[month]);      
        }

            string[] colors = {
              "Azure",
              "Aqua",
              "Brown",
              "Bronze",
              "Blue",
              "Black",
              "Yellow",
              "White",
              "Wheat",
              "Violet",
              "Turquoise",
              "Tomato",
              "Teal",
              "Silver",
              "Salmon",
              "Red",
              "Purple",
              "Pink",
              "Orange",
              "Olive",
              "Navy blue",
              "Navy",
              "Maroon",
              "Lime",
              "Grey",
              "Green",
              "Gold",
              "Dark blue",
              "Cyan",
              "Chocolate",
              };

        for (int i = 0; i < 100; i++){
          Random rnd = new Random();

          int color = rnd.Next(0,colors.Length);

          Console.WriteLine("Color is {0}",colors[color]); 

        }
    */
        //RangeTest();
        //RoundNumber();
        TruncateTest();
    }

    public static void RangeTest()
    {
        IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
        foreach (int num in squares)
            Console.WriteLine(num);
    }

    public static void RoundNumber()
    {
        float originalNumber1 = 1.23f;
        float originalNumber2 = 134.53f;
        float originalNumber3 = 1.50f;

        float roundedNumber1 = (float)Math.Ceiling(originalNumber1);
        float roundedNumber2 = (float)Math.Round(originalNumber2, 1);
        float roundedNumber3 = (float)Math.Floor(originalNumber3);

        Console.WriteLine("roundNumber1 is " + roundedNumber1);
        Console.WriteLine("roundNumber2 is " + roundedNumber2);
        Console.WriteLine("roundNumber3 is " + roundedNumber3);

    }

    public static void TruncateTest()
    {
        decimal decimalNumber = 32.8943m;

        Console.WriteLine(Math.Truncate(decimalNumber));

        decimalNumber = -32.8943m;

        Console.WriteLine(Math.Truncate(decimalNumber));

        float floatNumber = 32.8943f;

        Console.WriteLine(Math.Truncate(floatNumber));

        floatNumber = -32.8943f;

        Console.WriteLine(Math.Truncate(floatNumber));
    }
}