using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteDistributionCalculator
{
    class Binomial
    {
        private double p;
        public double N;

        public Binomial(double pnew, double Nnew)
        {
            p = pnew;
            N = Nnew;
        }

        public string getPMF()
        {
            return "(" + N.ToString() + " choose k)(" + p.ToString() + "^k)(" + (1 - p).ToString() + "^(" + N.ToString() + "-k))";
        }

        public string getMean()
        {
            return (N*p).ToString();
        }

        public string getResult(int arrivals)
        {
            return (Choose(N, arrivals) * Math.Pow(p, arrivals) * Math.Pow(1 - p, N - arrivals)).ToString();
        }

        private double Choose(double x, double y)
        {
            return Factorial(x) / (Factorial(y) * Factorial(x - y)); ;
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
