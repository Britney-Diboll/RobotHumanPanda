using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Panda : Thing, IPets
    {
        public string OwnerName { get; set; }
        private bool IsAsleep { get; set; }

        public void WakeUp()
        {
            IsAsleep = false;
            Console.WriteLine(this.Name + " wakes up at dawn");
        }

        public void FallAsleep()
        {
            IsAsleep = true;
            Console.WriteLine("Don't bother " + this.Name + " when she is sleeping!");
        }


        public Panda()
        {
            this.Name = "Fluffy";
            this.Birthday = new DateTime(2010, 12, 25);
            this.SayHello = "rawwwwwwwwwrrrrr";
            this.Food = "Bamboo shoots";
            this.FallAsleep();
        }


        public Panda(string name)
        {
            Name = name;
            Birthday = DateTime.Now;
        }
    }
}
