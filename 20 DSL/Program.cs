using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_DSL
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            const double R = 3;
            MyDelegate myDelegate = DlinaKruga;
            double L=myDelegate(R);
            myDelegate = SqrKruga;
            double S = myDelegate(R);
            myDelegate = VolSphere;
            double V = myDelegate(R);
            Console.ReadKey();
        }
        static double DlinaKruga(double R)
        {
            double L=(double)Math.PI * 2 * R;
            Console.WriteLine(L);
            return L;
        }
        static double SqrKruga(double R)
        {
            double S = (double)Math.Pow(R, 2) * Math.PI;
            Console.WriteLine(S);
            return S;
        }
        static double VolSphere(double R)
        {
           double V=Math.Pow(R, 3) * Math.PI*4/3;
            Console.WriteLine(V);
            return V;
        }
               
    }
}
