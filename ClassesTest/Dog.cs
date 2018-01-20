using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTest
{
    public class Dog : Mammal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string SpreadSound()
        {
            return "woof woof";
        }
    }
}
