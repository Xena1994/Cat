using System;

namespace CatLib
{
    public class Cat
    {
        public int Length { get; set; }

        public string Fact { get; set; }

        public Cat(string fact, int length)
        {
            Fact = fact;
            Length = length;
        }
    }
}
