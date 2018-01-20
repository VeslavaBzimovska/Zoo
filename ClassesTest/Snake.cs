using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTest
{
    public class Snake : Reptile
    {
        public Snake(string name, int age) : base(name, age)
        {
        }

        public override string SpreadSound()
        {
            return "psss";
        }
    }
}
