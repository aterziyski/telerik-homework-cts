using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4Person
{
    class Test
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Petar Petrov");
            Person person2 = new Person("Petar Cvetkov", 87);

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());

        }
    }
}
