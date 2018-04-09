using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotHumanPanda
{
    class Human : Thing
    {
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

        public Human()
        {
            this.Name = "Terry";
            this.Birthday = new DateTime(1990, 3, 3);
            this.SayHello = "Hi there!";
        }

        public List<IPets> Pets { get; set; } = new List<IPets>();

        public void Adopt(IPets pet)
        {
            this.Pets.Add(pet);
            pet.OwnerName = this.Name;
        }

        public Human(string name)
        {
            Name = name;
            Birthday = DateTime.Now;
        }
    }
}
