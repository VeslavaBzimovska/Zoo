using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ClassesTest
{
    public class Reptile : Animal
    {
        public Reptile(string name, int age) : base(name, age)
        {
        }

        public Color SkinColor { get; set; }
    }
}
