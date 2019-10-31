using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scaling
{
    class Program
    {
        static void Main(string[] args)
        {
            int sx;
            int sy;
            int x;
            int y;
            int x1;
            int y1;
            int x2;
            int y2;
            int x3;
            int y3;
            int x4;
            int y4;
            int result;
            Console.WriteLine("**************************Scaling*******************************");
            Console.WriteLine("\n\nEnter The Value of sx :");
            sx = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of sy :");
            sy = Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n\nEnter The Value of x1 :");
            x1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y1 :");
            y1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x2 :");
            x2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y2 :");
            y2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x3 :");
            x3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y3 :");
            y3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x4 :");
            x4 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y4 :");
            y4 = Int16.Parse(Console.ReadLine());
            x = sx*x1 + 0*y1;
            y = 0*x1 + sy*y1;
            Console.WriteLine("\n\nFirst Point is  (" + x + "," + y + ")");
            x = sx * x2 + 0 * y2;
            y = 0 * x2 + sy * y2;
            Console.WriteLine("Second Point is  (" + x + "," + y + ")");
            x = sx * x3 + 0 * y3;
            y = 0 * x3 + sy * y3;
            Console.WriteLine("Third Point is  (" + x + "," + y + ")");
            x = sx * x4 + 0 * y4;
            y = 0 * x4 + sy * y4;
            Console.WriteLine("Fourth Point is  (" + x + "," + y + ")");
            Console.ReadLine();

        }
    }
}
