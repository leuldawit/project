using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using circle;
using rectangle;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle.circle c = new circle.circle();
            rectangle.rectangle r = new rectangle.rectangle(); 

            Console.WriteLine(" Press 1 for circle\n Press 2 for rectangle");
            int choice = Convert.ToInt32(Console.ReadLine());
           
            do
            {
                if (choice != 1 || choice != 2)
                {
                    Console.WriteLine("invalid input! re-enter.");
                    choice = Convert.ToInt32(Console.ReadLine());
                }

            } while (choice != 1 && choice != 2);
            
                if (choice == 1)
                {
                    Console.WriteLine(" Press 1 for circle area \n Press 2 for circle perimeter");
                    choice = Convert.ToInt32(Console.ReadLine());
                
                do
                {
                    if (choice != 1 || choice != 2)
                    {
                        Console.WriteLine("invalid input! re-enter.");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
               
                } while (choice != 1 && choice != 2);

                
                        if (choice == 1)
                        {
                            Console.WriteLine("enter the radius");
                            double radius = Convert.ToInt32(Console.ReadLine());
                            c.radius = radius;
                            c.cal_area();
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("enter the radius");
                            double radius = Convert.ToInt32(Console.ReadLine());
                            c.radius = radius;
                            c.cal_perimeter();
                        }

                }
                else if (choice == 2)
                {
                    Console.WriteLine(" Press 1 for Rectangle area \n Press 2 for Rectangle perimeter");
                    choice = Convert.ToInt32(Console.ReadLine());

                do
                {
                    if (choice != 1 || choice != 2)
                    {
                        Console.WriteLine("invalid input! re-enter.");
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                } while (choice != 1 && choice != 2);
               
                        if (choice == 1)
                        {
                            Console.WriteLine("enter the length");
                            double length = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the width");
                            double width = Convert.ToInt32(Console.ReadLine());
                            r.length = length;
                            r.width = width;
                            r.cal_area();
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("enter the length");
                            double length = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the width");
                            double width = Convert.ToInt32(Console.ReadLine());
                            r.length = length;
                            r.width = width;
                            r.cal_perimeter();
                        }

                        
                    
                }
                        Console.ReadKey();
        }
    }
}
