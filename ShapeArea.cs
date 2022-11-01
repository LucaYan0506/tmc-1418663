using System;

class Program2
{
    public static void Main(string[] args)
    {
      int base_triangle = 0;
      string s1 = Console.ReadLine();  
      bool result1 = int.TryParse(s1, out base_triangle); 

      int height_triangle = 0;
      string s2 = Console.ReadLine();  
      bool result2 = int.TryParse(s2, out height_triangle); 
      
      if (result1 && result2)
        Console.WriteLine(triangleArea(base_triangle,height_triangle));
      else
          Console.WriteLine("invalid");

      int radius = 0;
      string s3 = Console.ReadLine();  
      bool result3 = int.TryParse(s3, out radius); 
         
      if (result3)
        Console.WriteLine(circleArea(radius));
      else
          Console.WriteLine("invalid");
      
     int base_rectangle = 0;
      string s4 = Console.ReadLine();  
      bool result4 = int.TryParse(s4, out base_rectangle); 

      int height_rectangle = 0;
      string s5 = Console.ReadLine();  
      bool result5 = int.TryParse(s5, out height_rectangle); 
      
      if (result4 && result5)
        Console.WriteLine(rectangleArea(base_rectangle,height_rectangle));
      else
          Console.WriteLine("invalid");
    }
    
    public static float triangleArea(int b, int h){
      return (float)(b * h / 2);
    }

    public static float circleArea(int r){
      return (float)(r * Math.PI);
    }

    public static float rectangleArea(int b, int h){
      return (float)(b * h);
    }
}