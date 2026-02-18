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
       /* {
           get
            {
                try { return this.Age;
                }
                catch { return 0; }
            }
            set
            {
                if (value <= 0)
                {
                    Age = 0;
                    Console.WriteLine("Введён некорректный возраст, присвоено значение 0");
                }
                else
                if (value >= 150)
                {
                    Age = 0;
                    Console.WriteLine("Введён некорректный возраст, присвоено значение 0");
                }
                else { Age = value; }
            }
        }*/

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
