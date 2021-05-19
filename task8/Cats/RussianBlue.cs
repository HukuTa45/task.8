using System;
using System.Collections.Generic;
using System.Text;

namespace task8.Cats
{
    public class RussianBlue : Cat
    {

        public RussianBlue(string name) : base(name)
        {
        }

        public override double Coefficient => 1.5;
    }
}
