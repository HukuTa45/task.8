using System;
using System.Collections.Generic;
using System.Text;
using task8.Cats;
using task8.Dogs;

namespace task8
{
    class SumCalculator
    {
        public double Calculate(List<Pet> pets)
        {
            double sum=0;
            foreach (Pet pet in pets)
            {
                switch (pet)
                {
                    case Cat cat:
                        sum = sum+100 + 50 * cat.Coefficient;
                        break;
                    case Dog dog:
                        sum = sum   + 100 + 70 * dog.Coefficient;
                        break;
                }
            }
            return sum;
        }
    }
}
