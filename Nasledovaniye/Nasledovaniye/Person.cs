using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovaniye
{
    class Person
    {
        public string name;
        private int Age;
        public int age;
       
        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Срабатывание конструктора Person(string name)");
        }
        public Person(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("Срабатывание конструктора Person(string name, int age)");
        }
        public Person() { }
    }
}
