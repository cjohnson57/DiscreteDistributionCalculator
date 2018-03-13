using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteDistributionCalculator
{
    class Poisson
    {
        private double lambda;
        private double T;

        public Poisson(double lambdanew, double Tnew)
        {
            lambda = lambdanew;
            T = Tnew;
        }

        public string getPMF()
        {
            return "((" + (lambda * T).ToString() + "^k)(e^-" + (lambda * T).ToString() + "))/(k!)";
        }

        public string getMean()
        {
            return (lambda * T).ToString();
        }

        public string getResult(int trials)
        {
            return (Math.Pow(lambda * T, trials) * Math.Pow(Math.E, -(lambda * T)) / Factorial(trials)).ToString();
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
