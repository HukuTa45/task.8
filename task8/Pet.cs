using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    public abstract class Pet
    {
        public string PetName;

        protected Pet(string petName)
        {
            PetName = petName;
        }

        public abstract double Coefficient { get; }

        public override string ToString()
        {
            return PetName;
        }
    }
}
