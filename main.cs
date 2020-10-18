using System;

namespace anuj
{
  class Program
  {
    static void Main(string[]args)
    {
      Console.WriteLine("  calculater");
      while (true){
        Console.Write("so this is a calculater Write what you want to :   ");
        string a = Console.ReadLine();
        switch (a)
        {
          case "add":
            Console.WriteLine("so, you want to add"); 
            Console.Write("enter first number:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number:  ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("this is the output: ");
            Console.WriteLine(x+y);
            Console.WriteLine("we have done");
            break; 
          case "subtract":
            Console.WriteLine("so, you want to subtract"); 
            Console.Write("enter first number:  ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number:  ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("this is the output: ");
            Console.WriteLine(x1-y1);
            Console.WriteLine("we have done");
            break; 
          case "multiply":
            Console.WriteLine("so, you want to multiply"); 
            Console.Write("enter first number:  ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number:  ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("this is the output: ");
            Console.WriteLine(x2-y2);
            Console.WriteLine("we have done");
            break; 
          case "divide":
            Console.WriteLine("so, you want to divide"); 
            Console.Write("enter first number:  ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number:  ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("this is the output: ");
            Console.WriteLine(x3/y3);
            Console.WriteLine("we have done");
            break;
        }
      }
    }
  }
}