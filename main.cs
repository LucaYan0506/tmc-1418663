using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

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
        RangeTest();
        RoundNumber();
        TruncateTest();
        GetLengthOfString("test");
        GetCharOfString("test", 1);
        GetSubString("test", 1, 2);
        ConvertToInt("112");
        ConvertToFloat("112.25");
    */

      
      /*
      int n1 = 0, n2 = 0;
      string s1 = Console.ReadLine();  
      string s2 = Console.ReadLine();  
      bool result1 = int.TryParse(s1, out n1); 
      bool result2 = int.TryParse(s2, out n2); 
      
      if (result1 && result2){
        int gcd = Gcd(n1,n2);
       //try to open the file and write into it.
       try
        {
         //open file called "result.txt"
            FileStream fileStream = File.Open("result.txt",
                FileMode.Append, FileAccess.Write);

          //create a streawriter (this allows me to write into the file)
            StreamWriter fileWriter = new StreamWriter(fileStream);
          //write the result to the file
            fileWriter.WriteLine(n1 + ":" + n2 + " = " + (n1 / gcd) + ":" + (n2 / gcd));
            //clear the buffer 
            fileWriter.Flush();
             //close the file
            fileWriter.Close();
        }
        //output the error, if there is any error
        catch (IOException ioe)
        {
            Console.WriteLine(ioe);
        }
      }else
          Console.WriteLine("invalid");
      */

      
      int n1 = 0;
      string s1 = Console.ReadLine();  
      bool result1 = int.TryParse(s1, out n1); 
      
      if (result1)
        Multiplication(n1);
      else
          Console.WriteLine("invalid");

    }

    public static void Multiplication(int n){
      //try to open the file and write into it.
       try
        {
         //open file "multiplication.txt"
            FileStream fileStream = File.Open("multiplication.txt",
                FileMode.Append, FileAccess.Write);

          //create a streawriter (this allows me to write into the file)
            StreamWriter fileWriter = new StreamWriter(fileStream);
          //write the mulitplication to the file
             for (int i = 1; i <= 10; i++){
              fileWriter.WriteLine(n + " * " + i + " = " + n * i);
            }
            //clear the buffer 
            fileWriter.Flush();
             //close the file
            fileWriter.Close();
        }
        //output the error, if there is any error
        catch (IOException ioe)
        {
            Console.WriteLine(ioe);
        }
    }
  
    public static int Gcd(int a, int b){
    //if a is equal to 0 return b
      if (a == 0)
        return b;
      //otherwise continue the calculation
      else
        return Gcd(b % a, a);
    }
 
    public static int Gcd_myVersion(int a, int b){
      if (a == 0)
        return b;
      if (b == 0)
        return a;
      
      int temp = Math.Abs(a-b);
      return Gcd_myVersion(temp, Math.Min(a,b));
      
    }

    public static int Gcd_myVersion2(int a, int b){
      int min_number = Math.Min(a,b);

      for (int i = min_number; i > 1; i--){
        if (a % i == 0 && b % i == 0)
          return i;
      }

      return 1;
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

    public static void GetLengthOfString(string str)
    {
        int length = str.Length;

        Console.WriteLine("{0} is {1} characters long", str, length);
    }
    public static void GetCharOfString(string str, int i)
    {
        Console.WriteLine("Character {0} of {1} is {2}", i, str, str[i]);
    }

    public static void GetSubString(string str, int start, int howMany)
    {
        Console.WriteLine("Substring of {0} is {1}", str, str.Substring(start, howMany));
    }

    public static void Combine2String(string str1, string str2)
    {
        Console.WriteLine("Joined string is: {0}", str1 + str2);
    }

    public static void ConvertToInt(string str)
    {
        Console.WriteLine("My number, 100 times bigger is: {0}", int.Parse(str) * 100);
    }

    public static void ConvertToFloat(string str)
    {
        Console.WriteLine("My number, 100 times bigger is: {0}", float.Parse(str) * 100);
    }
}