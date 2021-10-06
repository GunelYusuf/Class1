using System;
using System.Collections.Generic;
using System.Text;


namespace Class_Homee
{
    class Phone
    {
        public string name;
        public string marka;
        public double price;
        public string description;
       

        public string Detail()
        {
            return $"{name} {marka} {price}";
        }

        public string Feautures()
        {
            return $"{Detail()} və {description}";
        }
    }
}
