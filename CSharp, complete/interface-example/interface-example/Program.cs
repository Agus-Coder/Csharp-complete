using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Fido"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Adam"));
            dogs.Sort();
            foreach(Dog dog in dogs)
                Console.WriteLine(dog.Describe());
            Console.ReadKey();
        }
    }

    interface IAnimal //I means interface
    {
        string Describe(); // Public by deafault

        string Name // Public By default
        {
            get;
            set;
        }
    }

    class Dog: IAnimal, IComparable //two interfaces implemented!!
    {
        private string name;

        public Dog(string name)
        {
            this.Name = name;
        }

        public string Describe()
        {
            return "Hello, I'm a dog and my name is " + this.Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
                return this.name.CompareTo((obj as IAnimal).Name);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}