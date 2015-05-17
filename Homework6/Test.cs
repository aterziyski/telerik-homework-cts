using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Test
    {
        static void Main(string[] args)
        {
            Student student = new Student("Petar", "Nikolaev", "Velev", "12345", "Bulgaria, Sofia", "test@abv.bg", 2, Specialty.Informatiks, University.NewBulgarian, Faculties.Mathematics);
            Student student2 = new Student("Bobi", "Nikolaev", "Velev", "12345", "Bulgaria, Sofia", "test@abv.bg", 2, Specialty.Informatiks, University.NewBulgarian, Faculties.Mathematics);
            bool test1 = student.Equals(student2);
            string result = student.ToString();
            bool test2 = (student == student2);
            bool test5 = (student != student2);
            Console.WriteLine(result);
            Console.WriteLine(student.GetHashCode());
            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test5);

            Student studentClone = student.Clone();
            Console.WriteLine (studentClone.ToString());
            Console.WriteLine("The result of the compare student is: " + student.CompareTo(student2));
        }
    }
}
