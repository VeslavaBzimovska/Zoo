using System;

namespace ClassesTest
{
    public class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age)
        {
        }

        public FurType Fur { get; set; }
    }
}
