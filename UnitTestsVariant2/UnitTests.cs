using System;
using System.Security.Cryptography.X509Certificates;

namespace UnitTestsNS
{ 

    public class UnitTests2
    {
        private double t_a;
        private double t_b;
        private double t_f;

    private UnitTests2() { }

        //значения класса public
        public UnitTests2(double a, double b, double f)
        {
            t_a = a;
            t_b = b;
            t_f = f;

        }

        //функция возвращающая результат
        public double ret_f
        {
            get { return t_f; }
        }


        //функции для проверки
        public void Variant2(double x, double c)
        {
            if(x + 5 < 0 && c == 0 )
            {
                t_f = (1 / t_a * x) - t_b;
                return;
            }

            else if (x + 5 > 0 && c!=0)
            {
                t_f = (x - t_a) / x - 1;
                return;
            }

            else //в остальных случаях
            {
                t_f = (10 * x) / (c - 2);
                return;
            }
        }

        //основная программа
        public static void Main()
        {
            
            UnitTests2 UT = new UnitTests2();
            UT.t_a = 5;
            UT.t_b = 6;

            UT.Variant2(-7, 0);

            Console.WriteLine(UT.t_f);
        }

    }
}