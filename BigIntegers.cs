using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Task1
{
    class Calculate
    {
        static int count=0;
        BigInteger number1, number2;
        public Calculate(string n1, string n2)
        {
            this.number1 = BigInteger.Parse(n1);
            this.number2 = BigInteger.Parse(n2);
            count++;
        }
        public void Add()
        {
            BigInteger number3 = number1 + number2;
            Console.WriteLine("Addition of Big Integers:\nFunction: " + BigInteger.Add(number1, number2));
            Console.WriteLine("Simple:   " + number3+"\n");
        }
        public void Add(string n3) //An addition method that takes a new number as an input and subtracts from the existing number1
        {
            BigInteger number3 = BigInteger.Parse(n3);
            BigInteger number4 = number1 - number3;
            Console.WriteLine("Subtraction of Big Integers:\nFunction: "+BigInteger.Subtract(number1,number3));
            Console.WriteLine("Simple:   " + number4);
        }
        public void ObjectCount()
        {
            Console.WriteLine("\nThis is the object count: "+count+"\n");
        }
    }
    class BigIntegers
    {
        static void Main(string[] args)
        {
            string FirstNum = "12349872892389423897234789234987234892348972348972389742";
            string ThirdNum = "88900878766309097877089089989";
            string FourthNum = "1234987289238942389723478923498723489234897";
            
            Calculate c1 = new Calculate(FirstNum, FirstNum); //Same Sized Numbers
            c1.Add();
            Calculate c2 = new Calculate(FirstNum, ThirdNum); //Different sized numbers
            c2.Add();
            c2.Add(FourthNum); //Subtraction
            c2.ObjectCount();

            int c = 8 % 10;
            Console.WriteLine(c);

            //From Animal Class
            Goat m1 = new Goat();
            m1.Breathing();
            m1.CanMove();
            m1.Fly();
            m1.Type();
        }
    }
}
