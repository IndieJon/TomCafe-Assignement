using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe_Assignement
{
    class Beverage : Product
    {
        private double tradeIn;
        public Beverage() { }
        public Beverage(string n, double p, double tI) : base(n, p)
        {
            tradeIn = tI;
        }
        public override double GetPrice()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return $"Trade-In:{tradeIn}";
        }
    }
}
