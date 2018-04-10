using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Robot : Thing, IPets
    {
        public string OwnerName { get; set; }

        private bool IsAsleep { get; set; }
        public double VersionNumber { get; set; }

        public void StartUp()
        {
            IsAsleep = false;
            Console.WriteLine(this.Name + " takes a minute to boot up in the morning.");
        }
        public void ShutDown()
        {
            IsAsleep = true;
            Console.WriteLine(this.Name + " will shut down when it over heats.");
        }

        public Robot()
        {
            this.Name = "Robo-Bob";
            this.Birthday = new DateTime(2018, 1, 1);
            this.VersionNumber = 101;
            this.SayHello = "Beep Boop";
            this.Food = "Oil";
            this.ShutDown();
            this.StartUp();
        }

        public Robot(string name)
        {
            Name = name;
            Birthday = DateTime.Now;
        }


    }
}
