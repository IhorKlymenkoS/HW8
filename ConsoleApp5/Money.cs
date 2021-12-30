using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Money
    {
        private double _moneyValue;
        private double _exchangeRate;

        public int Penny =>(int)((_moneyValue % 1)*100);
        public int Bill => (int)_moneyValue;

        public double MoneyValue
        {
            get
            {
                return _moneyValue;
            }
            set
            {
                if (value > 0)
                {
                    _moneyValue = value;
                }
            }
        }

        public double ExchangeRate
        {
            get
            {
                return _exchangeRate;
            }
            set
            {
                if (value > 0)
                {
                    _exchangeRate = value;
                }
            }
        }

        public double Minus(double a)
        {
            if (a > 0)
            {
                _moneyValue -= a;
            }

            return _moneyValue;
        }

        public double Plus(double a)
        {
            if (a > 0)
            {
                _moneyValue += a;
            }

            return _moneyValue;
        }

        public double Multiply(double a)
        {
            if (a>0)
            {
                _moneyValue *= a;
            }

            return _moneyValue;
        }

        public double Convert(double a)
        {
            if (a > 0 && a<_exchangeRate)
            {
                _moneyValue *= a;
            }
            if (a > 0 && a > _exchangeRate)
            {
                _moneyValue /= a;
            }

            return _moneyValue;
        }

    }
}
