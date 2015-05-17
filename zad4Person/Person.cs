using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4Person
{
    class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person()
        {
            this.Name = "";
            this.Age = null;
        }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return "The name of the person is " + this.Name + " but the age is not said";
            }
            else
            {
                return "The name of the person is " + this.Name + " and its age is " + this.Age;
            }
        }

    }
}
