using System;

namespace Class_Homee
{
    class Iphone:Phone
    {
        public Iphone() //:this("Nokia",800, "Lumia-510","Windows") 
        {
            Console.WriteLine("Smart Phones");
        }

        public Iphone(string name1, string
            marka1, string description1)
        {
            name = name1;
            marka = marka1;
            description = description1;
        }

        public Iphone(string name1, double price1, string
            marka1, string description1) : this(name1, marka1, description1)
        {
            price = price1;
        }

    }
}
