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
        RangeTest();
    }

    public static void RangeTest()
    {
        IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
        foreach (int num in squares)
            Console.WriteLine(num);
    }
}