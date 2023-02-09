using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SM_MP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(); 
            while (true) {
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");
                //
                int selection = Convert.ToInt16(Console.ReadLine());

                if (selection == 1) {
                    Console.WriteLine("Radius: "+circle.GetRadius());
                    
                } else if (selection == 2)
                {
                    Console.WriteLine("Set Radius: ");
                    int radius = Convert.ToInt16(Console.ReadLine());
                    circle.SetRadius(radius);
                   
                } else if (selection == 3)
                {
                    Console.WriteLine("Circumference of Circle is: "+ circle.GetCircumference());
                } else if (selection == 4)
                {
                    Console.WriteLine("Area of Circle: "+ circle.GetArea());
                } else if (selection >= 5) {
                    Environment.Exit(1);
                }
            }
        }
    }
}
