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
            }

           
        }

    }
}
