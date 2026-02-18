namespace Nasledovaniye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee("Tom", 22, "Microsoft");
            Console.WriteLine(tom.name+" "+ tom.age + " "+tom.company);
        }
    }


    
   
    }

