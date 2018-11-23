using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOftheCode
{
    public class Person
    {
        public enum TypeEnum
        {
            Student = 1, 
            Professor = 2
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public TypeEnum Type { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
    }
}
