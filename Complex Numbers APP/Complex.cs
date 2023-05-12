using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Complex_Numbers_APP
{
    public class Complex
    {
        private double real;
        private double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public double Real
        {
            get { return  real; }
        }

        public double Imaginary
        {
            get { return imaginary; }
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real -  c2.Real, c1.Imaginary -  c2.Imaginary);
        }


        public static Complex operator *(Complex c1, Complex c2)
        {
            double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginaryPart = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new Complex(realPart, imaginaryPart);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double realPart = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / (Math.Pow(c2.Real, 2) + Math.Pow(c2.Imaginary, 2));
            double imaginaryPart = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / (Math.Pow(c2.Real, 2) + Math.Pow(c2.Imaginary, 2));
            return new Complex(realPart, imaginaryPart);
        }

        public static Complex operator ^(Complex c1, int power)
        {
            Complex result = new Complex(c1.Real, c1.Imaginary);
            for (int i = 1; i < power; i++)
            {
                result = result * c1;
            }
            return result;
        }




    }
}
