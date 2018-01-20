using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTest
{
    public abstract class Animal:System.Object
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool IsFree { get; private set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsFree = true;
        }

        public virtual string SpreadSound()
        {
            return string.Empty;
        }

        public void FreeAnimal()
        {
            IsFree = true;
        }

        public void PutToCell()
        {
            IsFree = false;
        }
    }
}
