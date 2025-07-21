using CSharpClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VBClassLibrary;

namespace CsharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama = "John Doe";

            int a = 12;
            int b = 8;

            int hasilTambah = MyFunction.Add(a, b);
            Console.WriteLine("Hasil Tambah: " + hasilTambah);

            MyVBFunction myVb = new MyVBFunction();
            Console.WriteLine(myVb.GetGreeting("John"));

            var d = 12;
            //d = "Erick";

            int h = 12;
            double g = h;
            double i = 12.5;
            int j = Convert.ToInt32(i);


            Console.WriteLine("b: " + b);
            int c = b;
            Console.WriteLine("c: " + c);
            b = 10;
            Console.WriteLine("c: " + c);


            Person person1 = new Person("Alice", 30);
            Person person2 = new Person();
            person2.Name = "Bob";
            person2.Age = 25;

            Person person3 = person2;
            Console.WriteLine("Person 3: " + person3.Name);
            person2.Name = "Charlie";
            Console.WriteLine("Person 3: " + person3.Name);

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

        public string GetName()
        {
            return Name;
        }
    }
}
