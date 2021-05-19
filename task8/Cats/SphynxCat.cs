using System;
using System.Collections.Generic;
using System.Text;

namespace task8.Cats
{
    public class SphynxCat : Cat
    {
        public SphynxCat(string name) : base(name)
        {
        }

        public override double Coefficient => 1;
    }
}
