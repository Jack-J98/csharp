using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    public class Payment : ITax
    {
        public delegate void OnAmountChanged(float oldAmount, float newAmount);
        public event OnAmountChanged AmountChanged;
        float amount;

        public float Amount
        {
            get { return amount; }
            set
            {
                if (amount != value && AmountChanged != null)
                {
                    AmountChanged(amount, value);
                }
                amount = value;
            }
        }
        public Payment()
        {

        }
        public Payment(float amount)
        {
            this.amount = amount;
        }

        public float ComputeTax()
        {
            return 10 * amount / 100;
        }
    }
}
