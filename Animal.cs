using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    interface ILivingThings
    {
        void Breathing();
        void CanMove();
    }
    interface IAnimals : ILivingThings
    {
        void HaveLegs();
        void HaveEyes();
        void HaveMouth();
    }
    abstract class Mammal : IAnimals
    {
        public void Breathing()
        {
            Console.WriteLine("They can breathe");
        }
        public void CanMove()
        {
            Console.WriteLine("They can move");
        }
        public void HaveLegs()
        {
            Console.WriteLine("They have legs");
        }
        public void HaveEyes()
        {
            Console.WriteLine("They have eyes");
        }
        public void HaveMouth()
        {
            Console.WriteLine("They have mouth");
        }
        public abstract void Fly();
    }
    class Bats : Mammal
    {
        public override void Fly()
        {
            Console.WriteLine("Bats can fly");
        }
    }
    class FourLeggedMammal : Mammal
    {
        public override void Fly()
        {
            Console.WriteLine("Four Legged Mammals cannot fly");
        }
        public virtual void Type()
        {
            Console.WriteLine("Some are carnivores and some are hebrivores");
        }
    }
    class Lion : FourLeggedMammal
    {
        public override void Type()
        {
            base.Type();
            Console.WriteLine("Lion is a carnivores");
        }
    }
    class Goat : FourLeggedMammal
    {
        public override void Type()
        {
            base.Type();
            Console.WriteLine("Goat is a Hebrivores");
        }
    }
}
