using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trtpo_fractal_lab1
{
    class Complex
    {
        private double re;
        private double im;
        public Complex(double rl, double ig)
        {
            re = rl;
            im = ig;
        }
        public static Complex operator +(Complex a, Complex b) => new Complex(a.re + b.re, a.im + b.im);
        public static Complex operator *(Complex a, Complex b) => new Complex(a.re * b.re - a.im * b.im, 2 * a.re * b.im);
        public double getAbs() => re * re + im * im;
    }
}
