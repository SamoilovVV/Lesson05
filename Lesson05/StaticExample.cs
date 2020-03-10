using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    public class Account
    {
        public static double Bonus;

        public double TotalSum { get; private set; }

        public Account(double sum)
        {
            TotalSum = sum + Bonus;
        }

        static Account()
        {
            Bonus = 100;
            Console.WriteLine($"Вызван статический конструктор! Бонус: {Bonus}");
        }
    }

    public static class StaticAccount
    {
        private static double _minSum = 100.0;
        public static double MinSum
        {
            get => _minSum;
            set { if (value > 0) _minSum = value; }
        }

        public static double GetSum(double sum, double rate, double period)
        {
            double result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }
}
