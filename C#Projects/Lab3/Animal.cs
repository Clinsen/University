using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Animal
    {
        protected int age;
        protected double weight;
        protected double upkeep_cost;

        public virtual void print_info()
        {
            Console.WriteLine("Animal info:\nAge: " + this.age + "\nWeight: " + this.weight + "\nUpkeep cost: " + this.upkeep_cost);
        }

        public Animal(int age, double weight, double upkeep_cost)
        {
            this.weight = weight;
            this.age = age;
            this.upkeep_cost = upkeep_cost;
        }
    }
}
