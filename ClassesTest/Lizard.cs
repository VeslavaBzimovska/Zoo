using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTest
{
    public class Lizard : Reptile
    {
        public Lizard(string name, int age) : base(name, age)
        {
        }

        public override string SpreadSound()
        {
            return "ssss";
        }
    }
}
