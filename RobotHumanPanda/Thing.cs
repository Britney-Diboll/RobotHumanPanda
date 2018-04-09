using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Thing
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string SayHello { get; set; }




        public void MyName()
        {
            Console.WriteLine("The name for me is: " + this.Name);
            Console.ReadLine();
        }

        public void Hello()
        {
            Console.WriteLine(this.Name + " said " + this.SayHello);
            Console.ReadLine();
        }
    }
}
