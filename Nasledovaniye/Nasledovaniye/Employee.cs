using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovaniye
{
    class Employee : Person
    {
        public string company;
        public Employee() { }
        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Срабатывание конструктора Employee(string name, int age, string company)");
        }
    }
    class Employee2 : Employee
    {
        public int salary { get; set; }
        public Employee2(int salary)
        {
            this.salary = salary;
        }
    }
}
