// Alexander Raptis, 14 Feb 2023

using System;
using System.Globalization;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Chicken : Animal
    {
        public double weight;
        public string breed;
        public decimal price;

        public Chicken()
        {
            name = "none";
            weight = 0.0;
            breed = "none";
            price = 0.0M;
        }

        public Chicken(string _name, double _weight, string _breed, decimal _price)
        {
            name = _name;
            weight = _weight;
            breed = _breed;
            price = _price;
        }

        public new void display()
        {
            Console.WriteLine("Chicken Info");
            Console.WriteLine(new string('-', 16));
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Weight (lb): {0}", weight);
            Console.WriteLine("Breed: {0}", breed);
            Console.WriteLine("Price (USD): {0}", price.ToString("C", new CultureInfo("en-US")));
        }
    }

    class Turkey : Animal
    {
        public double weight;
        public string breed;
        public decimal price;
        public uint age;

        public Turkey()
        {
            name = "none";
            weight = 0.0;
            breed = "none";
            price = 0.0M;
            age = 0;
        }

        public Turkey(string _name, double _weight, string _breed, decimal _price, uint _age)
        {
            name = _name;
            weight = _weight;
            breed = _breed;
            price = _price;
            age = _age;
        }

        public new void display()
        {
            Console.WriteLine("Turkey Info");
            Console.WriteLine(new string('-', 16));
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Weight (lb): {0}", weight);
            Console.WriteLine("Breed: {0}", breed);
            Console.WriteLine("Price (USD): {0}", price.ToString("C", new CultureInfo("en-US")));
            Console.WriteLine("Age: {0} years", age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Chicken chicken1 = new Chicken();
            chicken1.name = "Pedro";
            chicken1.weight = 6.4;
            chicken1.breed = "Barred Rock";
            chicken1.price = 15.99M;

            chicken1.display();

            //derived class object using parameterized constructor
            Chicken chicken2 = new Chicken("John", 5.34, "Buff Orpington", 24.99M);
            chicken2.display();

            // Turkey class
            Turkey turkey1 = new Turkey();

            turkey1.name = "Sam";
            turkey1.breed = "Bronze";
            turkey1.weight = 7.5;
            turkey1.price = 29.99M;
            turkey1.age = 3;

            turkey1.display();

            Turkey turkey2 = new Turkey("Jackson", 8.3, "Royal Palm", 32.56M, 2);
            turkey2.display();
        }

    }
}
