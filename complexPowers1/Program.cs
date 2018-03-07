using System;
using System.Numerics;//add in refernces

namespace complexPowers1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 20;i++){
                Complex c1 = Complex.Pow(Complex.ImaginaryOne, i);
                Console.WriteLine("j^{0}={1:N}+j{2:N}", i, c1.Real, c1.Imaginary);
                Console.WriteLine("j^{0}=magnitude= {1:N}, angle= {2:N} degrees\n", 
                                  i, c1.Magnitude, c1.Phase*180/Math.PI);

            }
            Console.WriteLine("completed calculation");
        }
    }
}
