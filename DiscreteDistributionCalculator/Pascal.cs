using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteDistributionCalculator
{
    class Pascal
    {
        private double q;
        public double k;

        public Pascal(double qnew, double knew)
        {
            q = qnew;
            k = knew;
        }

        public string getPMF()
        {
            return "(N-1 choose " + (k-1).ToString() + ")(" + q.ToString() + "^"+ k.ToString() +")(" + (1 - q).ToString() + "^(N-" + k.ToString() + "))";
        }

        public string getMean()
        {
            return (k / q).ToString();
        }

        public string getResult(int arrivals)
        {
            return (Choose(arrivals - 1, k - 1) * Math.Pow(q, k) * Math.Pow(1 - q, arrivals - k)).ToString();
        }

        private double Choose(double x, double y)
        {
            return Factorial(x) / (Factorial(y) * Factorial(x - y));
        }

        private double Factorial(double x)
        {
            double y = 1;
            for (int i = 1; i <= x; i++)
            {
                y *= i;
            }
            return y;
        }
    }
}
