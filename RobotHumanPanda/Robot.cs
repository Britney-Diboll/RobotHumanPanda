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
        }
        public void ShutDown()
        {
            IsAsleep = true;
        }

        public Robot()
        {
            this.Name = "Robo-Bob";
            this.Birthday = new DateTime(2018, 1, 1);
            this.VersionNumber = 101;
            this.SayHello = "HeLlO tHeRe";
        }


        
    }
}
