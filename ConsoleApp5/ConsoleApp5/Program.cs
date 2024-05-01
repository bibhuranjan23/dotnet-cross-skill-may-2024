using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //InputDemo();
            VoteEligibilityTest();
            Console.ReadKey();
        }

        public static void InputDemo()
        {
            string name = "";
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Name :{0}", name);
            Console.WriteLine($"Name :{name}");
        }

        public static void VoteEligibilityTest()
        {
            string name;
            byte age;
            Console.WriteLine("Enter Name of the Person :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age of the Person :");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Name:"+name+",age:"+age);
            Console.WriteLine("Name:{0},Age:{1}",name,age);
            Console.WriteLine($"Name:{name},Age:{age}");
            if (age >= 18)
            {
                Console.WriteLine("Person is Elligible for Vote");
            }
            else
            {
                Console.WriteLine("Person is Not Elligible for Vote");
            }
        }
    }
}
