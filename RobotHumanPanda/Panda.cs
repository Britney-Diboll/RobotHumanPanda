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
        }
        public void FallAsleep()
        {
            IsAsleep = true;
        }

        public string Eat(string food)
        {
            return ($"Eating :{food}");
        }

        public Panda()
        {
            this.Name = "Fluffy";
            this.Birthday = new DateTime(2010, 12, 25);
            this.SayHello = "rawwwwwwwwwrrrrr";
        }
    }
}
