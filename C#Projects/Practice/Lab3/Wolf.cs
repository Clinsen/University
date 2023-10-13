using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Wolf : Animal
    {
        private string breed;
        private string habitat;

        public Wolf(int age, double weight, double upkeep_cost, string breed, string habitat) : base(age, weight, upkeep_cost)
        {
            this.breed = breed;
            this.habitat = habitat;
        }

        public override void print_info()
        {
            Console.WriteLine("Animal info:\nAge: " + this.age + "\nWeight: " + this.weight + "\nUpkeep cost: " + this.upkeep_cost
            + "\nBreed: " + this.breed + "\nHabitat: " + this.habitat);
        }
    }
}
