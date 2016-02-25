using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2_3
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    enum CurrencyTypes { UAH = 1, USD, EU };

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public double Amount { private set; get; }
        public CurrencyTypes CurrencyType { private set; get; }

        // 3) declare parameter constructor for properties initialization
        public Money()
        {
            
        }

        public Money(double set_Amount, CurrencyTypes set_CurrencyTypes)
        {
            Amount = set_Amount;
            CurrencyType = set_CurrencyTypes;
        }

        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money m1, Money m2)
        {
            Money result = new Money(m1.Amount + m2.Amount, m1.CurrencyType);
            return result;
            
        }

        public static Money operator +(Money m1, double m2)
        {
            Money result = new Money(m1.Amount + m2, m1.CurrencyType);
            return result;

        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money m1)
        {
            Money result = new Money(--m1.Amount, m1.CurrencyType);
            return result;
        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money m1, int mult)
        {
            Money result = new Money(m1.Amount *= mult, m1.CurrencyType);
            return result;
        }

        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator >(Money m1, Money m2)
        {
            
            if (m1.Amount > m2.Amount)
                return true;
            else
                return false;
        }

        public static bool operator <(Money m1, Money m2)
        {

            if (m1.Amount < m2.Amount)
                return true;
            else
                return false;
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object

        public static bool operator true(Money m1)
        {

            if (m1.Amount > 0)
                return true;
            else
                return false;
        }
        public static bool operator false(Money m1)
        {

            if (m1.Amount < 0)
                return true;
            else
                return false;
        }

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        //public static explicit operator double(Money d1)
        //{
        //    double result = d1.Amount;
        //    return result;
        //}

        public static implicit operator double(Money d1)
        {
            double result = d1.Amount;
            return result;
        }

        //--------------//
        //public static explicit operator Money (double d1)
        //{
        //    Money result = new Money(d1, CurrencyTypes.UAH);
        //    return result;
        //}

        public static implicit operator Money(double d1)
        {
            Money result = new Money(d1, CurrencyTypes.UAH);
            return result;
        }

        //--------------//



        //public static explicit operator string(Money m1)
        //{
        //    string result = m1.Amount.ToString();
        //    return result;
        //}

        public static implicit operator string(Money m1)
        {
            string result = m1.Amount.ToString();
            return result;
        }

    }
}
