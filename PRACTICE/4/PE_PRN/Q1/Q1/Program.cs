using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class Program
    {
        public static void notifyAmountChanged(float oldAmount, float newAmount)
        {
            Console.WriteLine("Amount changed - old value: {0}, new value: {1}", oldAmount, newAmount);
        }
        static void Main(string[] args)
        {
            Payment payment = new Payment { Amount = 1000 };
            payment.AmountChanged += notifyAmountChanged;
            payment.Amount = 990;
            Console.WriteLine("Tax: " + payment.ComputeTax());
            Console.ReadKey();
        }
    }
}
