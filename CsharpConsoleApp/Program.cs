using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama = "John Doe";

            int a = 12;
            int b = 8;

            Console.WriteLine("b: " + b);
            int c = b;
            Console.WriteLine("c: " + c);
            b = 10;
            Console.WriteLine("c: " + c);


            Person person1 = new Person("Alice", 30);
            Person person2 = new Person();
            person2.Name = "Bob";
            person2.Age = 25;

        }
    }

    public class Person
    {
        //public string Name { get; set; }

        /*private string name;
        public string getName()
        {
            return name;
        }

        public void setName(string value)
        {
            name = value;
        }*/

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }



        public int Age { get; set; }

        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
