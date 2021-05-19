using System;
using System.Collections.Generic;
using System.Text;

namespace task8.Cats
{
    public class BritishCat : Cat
    {
         
        public BritishCat(string name) : base(name)
        {
        }

        public override double Coefficient => 2;
    }
}

