namespace DZ5
{
    internal class RationalNumber
    {
        private int _numerator;     // числитель 
        private int _denominator;   // знаменатель

        internal int Numerator
        { 
            get { return _numerator; } 
        }
        internal int Denominator
        {
            get { return _denominator; }
        }

        internal RationalNumber(int numerator) // целое число
        {
            _numerator = numerator;
            _denominator = 1;
        }

        internal RationalNumber(int numerator, int denominator)
        {
            if (denominator <= 0) throw new ArgumentException("denominator must be positive, > 0");

            _numerator = numerator;
            _denominator = denominator;
        }


        // overriding comparison operators 
        // переопределение операторов сравнения
        public override bool Equals(object obj)
        {
            return Equals(obj as RationalNumber);
        }
        public bool Equals(RationalNumber num)
        {
            if (num is null)
            {
                return false;
            }                

            if (this.Numerator == num.Numerator && this.Denominator == num.Denominator)
            {
                return true;
            }            
            else if (this.Numerator * num.Denominator == this.Denominator * num.Numerator)
            {
                //для этой части нужна консультация бизнеса - что должно возвращаться когда дроби математически равны, но не идентичны (1/3 == 2/6)
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Numerator, this.Denominator);
        }
        public static bool operator ==(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator == num2.Denominator) // если знаменатель одинаковый
            {
                if (num1.Numerator == num2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else // если знаменатель разный
            {
                if ((num1.Numerator * num2.Denominator) == (num2.Numerator * num1.Denominator))
                {
                    return true;
                }
                return false;
            }
        }
        public static bool operator !=(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator == num2.Denominator) // если знаменатель одинаковый
            {
                if (num1.Numerator != num2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else // если знаменатель разный
            {
                if ((num1.Numerator * num2.Denominator) != (num2.Numerator * num1.Denominator))
                {
                    return true;
                }
                return false;
            }
        }
        public static bool operator <=(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator == num2.Denominator) // если знаменатель одинаковый
            {
                if (num1.Numerator <= num2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else // если знаменатель разный
            {
                if ((num1.Numerator * num2.Denominator) <= (num2.Numerator * num1.Denominator))
                {
                    return true;
                }
                return false;
            }
        }
        public static bool operator >=(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator == num2.Denominator) // если знаменатель одинаковый
            {
                if (num1.Numerator >= num2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else // если знаменатель разный
            {
                if ((num1.Numerator * num2.Denominator) >= (num2.Numerator * num1.Denominator))
                {
                    return true;
                }
                return false;
            }
        }
        public static bool operator <(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator == num2.Denominator) // если знаменатель одинаковый
            {
                if (num1.Numerator < num2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else // если знаменатель разный
            {
                if ((num1.Numerator * num2.Denominator) < (num2.Numerator * num1.Denominator))
                {
                    return true;
                }
                return false;
            }
        }
        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator == num2.Denominator) // если знаменатель одинаковый
            {
                if (num1.Numerator > num2.Numerator)
                {
                    return true;
                }
                return false;
            }
            else // если знаменатель разный
            {
                if ((num1.Numerator * num2.Denominator) > (num2.Numerator * num1.Denominator))
                {
                    return true;
                }
                return false;
            }
        }



        // overriding math operators 
        // переопределение математических операторов
        public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
        {
            int _num;
            int _den;

            if (num1.Denominator == num2.Denominator) // если знаменатель одинаковый
            {
                _num = num1.Numerator + num2.Numerator;
                _den = num1.Denominator;
            }
            else // если знаменатель разный
            {
                _num = (num1.Numerator * num2.Denominator) + (num2.Numerator * num1.Denominator);
                _den = (num1.Denominator * num2.Denominator);
            }
            return TrySimplifyFraction(_num, _den);
        }
        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            int _num;
            int _den;

            if (num1.Denominator == num2.Denominator) // если знаменатель одинаковый
            {
                _num = num1.Numerator - num2.Numerator;
                _den = num1.Denominator;
            }
            else // если знаменатель разный
            {
                _num = (num1.Numerator * num2.Denominator) - (num2.Numerator * num1.Denominator);
                _den = (num1.Denominator * num2.Denominator);
            }
            return TrySimplifyFraction(_num, _den);
        }
        public static RationalNumber operator ++(RationalNumber num)
        {
            return TrySimplifyFraction(num.Numerator + num.Denominator, num.Denominator);
        }
        public static RationalNumber operator --(RationalNumber num)
        {
            return TrySimplifyFraction(num.Numerator - num.Denominator, num.Denominator);
        }
        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        {
            return TrySimplifyFraction(num1.Numerator * num2.Numerator, num1.Denominator * num2.Denominator);
        }
        public static RationalNumber operator /(RationalNumber num1, RationalNumber num2)
        {
            if (num2.Numerator == 0) 
            { 
                throw new InvalidOperationException("Can't divide by zero!"); 
            }

            return TrySimplifyFraction(num1.Numerator * num2.Denominator, num1.Denominator * num2.Numerator);
        }
        public static RationalNumber operator %(RationalNumber num1, RationalNumber num2)
        {
            //убираем знаки дробей
            RationalNumber result = new RationalNumber(Math.Abs(num1.Numerator), num1.Denominator);
            num2._numerator = (Math.Abs(num2.Numerator));

            if (num2.Numerator == 0)
            {
                throw new InvalidOperationException("Can't divide by zero!");
            }
            else if (result == num2)
            {
                return new RationalNumber(0, 1);
            }
            else if (result < num2)
            {
                return num1;
            }

            // получаем остаток
            while (result >= num2)
            {
                result = result - num2;
            }

            //возвращаем знак дроби
            if (num1.Numerator < 0)
            {
                result._numerator = result._numerator * -1;
            }

            return TrySimplifyFraction(result.Numerator, result.Denominator);
        }

        // переопределение преобразований
        // overriding casts 
        public override string ToString()
        {
            if (this._numerator == 0)
            {
                return "0";
            }
            
            string result = "";

            if (this._numerator == this._denominator)
            {
                return result + "1";
            }
            if (this._denominator == 1)
            {
                return result + this._numerator;
            }
            return result + this._numerator + "/" + this._denominator;
        }
        public static implicit operator float(RationalNumber num)
        {
            return (float)num.Numerator / num.Denominator;
        }
        public static implicit operator int(RationalNumber num)
        {
            return num.Numerator / num.Denominator;
        }


        private static RationalNumber TrySimplifyFraction(int num, int den)
        {
            int commonDivisor = CommonDivisor(num, den);

            if (commonDivisor > 0) // есть общий делитель
            {
                return new RationalNumber(num / commonDivisor, den / commonDivisor);
            }
            else // возвращаем как есть
            {
                return new RationalNumber(num, den);
            }
        }
        private static int CommonDivisor(int num, int den)
        {
            num = Math.Abs(num);
            //den = Math.Abs(den); // не может быть отрицательной
            while (den != 0 && num != 0)
            {
                if (num % den > 0)
                {
                    var temp = num;
                    num = den;
                    den = temp % den;
                }
                else break;
            }
            if (den != 0 && num != 0) return den;
            return 0;
        }
    }
}
