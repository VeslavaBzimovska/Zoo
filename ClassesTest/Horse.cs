using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTest
{
    public class Horse : Mammal
    {
        public Horse(string name, int age) : base(name, age)
        {
        }

        public override string SpreadSound()
        {
            return "igaga";
        }
    }
}
