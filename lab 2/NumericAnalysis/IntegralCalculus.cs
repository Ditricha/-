using System;

namespace NumericAnalysis
{
    public class IntegralCalculus
    {
        // метод трапеции с заданной точностью
        public static double Calculate(Func<double, double> func, double x1, double x2, double precision)
        {
            double integral0, integral1;
            int n = 2;

            integral0 = TrapezoidArea(func, x1, x2, n);

            integral1 = 0;
            while (Math.Abs(integral0 - integral1) > precision) {
                integral1 = integral0;
                n = n * 2;

                integral0 = TrapezoidArea(func, x1, x2, n);
            }
            return integral0;
        }

        // метод нахождения площади трапеции при заданном количестве интервалов
        public static double TrapezoidArea(Func<double, double> func, double x1, double x2, int n)
        {
            double integral, x, h;

            h = (x2 - x1) / n;
            x = x1;
            integral = 0;
            for (int i = 0; i <= n - 1; i++) {
                integral += func(x);
                x += h;
            }
            integral = h * ((func(x1) + func(x2)) / 2 + integral);

            return integral;
        }

    }
}
