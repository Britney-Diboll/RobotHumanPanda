using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new List<Thing>();
            obj.Add(new Panda());
            obj.Add(new Human());
            obj.Add(new Robot());

            foreach(var thing in obj)
            {
                thing.MyName();
                thing.Hello();
                thing.DayBirth();
                Console.ReadLine();
            }



            
            var Larry = new Human("Larry");
            Console.WriteLine($"Welcome to the world {Larry.Name}, you were born on {Larry.Birthday}");


            var Panda1 = new Panda("Panda1");
            Console.WriteLine($"Welcome to the world {Panda1.Name}, you were born on {Panda1.Birthday}");


            var Robot1 = new Robot("Robot1");
            Console.WriteLine($"Welcome to the world {Robot1.Name}, you were born on {Robot1.Birthday}");
            Console.ReadLine();


        }

    }
}
