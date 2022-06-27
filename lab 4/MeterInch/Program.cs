using System;

namespace MeterInch
{


    public struct Meter<T> where T : struct, IEquatable<T>, IComparable<T>
    {
        //1 дюйм = 0,0254 метр
        public T num;

        public Meter(T num)
        {
            this.num = num;
        }

        //унарный оператор +
        public static Meter<T> operator +(Meter<T> a) => new Meter<T>(Sum(a.num, 1.0));

        //унарный оператор -
        public static Meter<T> operator -(Meter<T> a) => new Meter<T>(Minus(a.num, 1.0));

        //бинарный оператор +
        public static Meter<T> operator +(Meter<T> a, Meter<T> b) 
        { 
            return new Meter<T>(Sum(a.num, b.num)); 
        }
        public static Meter<T> operator +(Meter<T> a, Inch<T> b) => new Meter<T>(Sum(a.num, Multiply(b.num,0.0254)));
        public static Meter<T> operator +(Inch<T> b, Meter<T> a) => new Meter<T>(Sum(a.num, Multiply(b.num, 0.0254)));

        //бинарный оператор -
        public static Meter<T> operator -(Meter<T> a, Meter<T> b) => new Meter<T>(Minus(a.num, b.num));
        public static Meter<T> operator -(Inch<T> a, Meter<T> b) => new Meter<T>(Minus(Multiply(a.num, 0.0254), b.num));
        public static Meter<T> operator -(Meter<T> b, Inch<T> a) => new Meter<T>(Minus(Multiply(a.num, 0.0254), b.num));

        //бинарный оператор *   
        public static Meter<T> operator *(Meter<T> a, Meter<T> b) => new Meter<T>(Multiply(a.num, b.num));
        public static Meter<T> operator *(Meter<T> a, Inch<T> b) => new Meter<T>(Multiply(a.num, Multiply(b.num, 0.0254)));
        public static Meter<T> operator *(Inch<T> b, Meter<T> a) => new Meter<T>(Multiply(a.num, Multiply(b.num, 0.0254)));

        //бинарный оператор /
        public static Meter<T> operator /(Meter<T> a, Meter<T> b) => new Meter<T>(Divide(a.num, b.num));
        public static Meter<T> operator /(Meter<T> a, Inch<T> b) => new Meter<T>(Divide(a.num, Multiply(b.num, 0.0254)));
        public static Meter<T> operator /(Inch<T> b, Meter<T> a) => new Meter<T>(Divide(Multiply(b.num, 0.0254), a.num));

        //операторы сравнения
        public static bool operator ==(Meter<T> a, Meter<T> b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(Meter<T> a, Meter<T> b)
        {
            return !Equals(a, b);
        }

        public static bool operator >(Meter<T> a, Meter<T> b)
        {
            return CompareMore(a.num, b.num);
        }

        public static bool operator <(Meter<T> a, Meter<T> b)
        {
            return CompareLess(a.num, b.num);
        }

        public static bool operator >=(Meter<T> a, Meter<T> b)
        {
            return CompareMore(a.num, b.num) || Equals(a, b);
        }

        public static bool operator <=(Meter<T> a, Meter<T> b)
        {
            return CompareLess(a.num, b.num) || Equals(a, b);
        }

        
        private static bool Equals(T a, T b)
        {
            return ((dynamic) a == (dynamic) b);
        }

        private static bool CompareMore(T a, T b)
        {
            return ((dynamic)a > (dynamic)b);
        }

        private static bool CompareLess(T a, T b)
        {
            return ((dynamic)a < (dynamic)b);
        }
        
        //методы для действий суммирования, вычитания, умножения, деления типов и т.д.
        private static T Sum(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        private static T Sum(T a, double b)
        {
            return (dynamic)a + (dynamic)b;
        }

        private static T Minus(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }

        private static T Minus(T a, double b)
        {
            return (dynamic)a - (dynamic)b;
        }

        private static T Multiply(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }

        private static T Multiply(T a, double b)
        {
            return (dynamic)a * (dynamic)b;
        }

        private static T Divide(T a, T b)
        {
            return (dynamic)a  / (dynamic)b;
        }

        public static implicit operator Meter<T>(Inch<T> inch) => new Meter<T>(Multiply(inch.num,0.0254));

        public static explicit operator Inch<T>(Meter<T> metr) => new Inch<T>(Multiply(metr.num, 39.3701));

        //перегруженные методы
        public override string ToString() => $"{num}";

        public override bool Equals(object obj)
        {
            if (obj is Meter<T> objectType)
            {
                return Equals(this.num, objectType.num);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(num);
        }


    }


    public struct Inch<T> where T : struct, IEquatable<T>, IComparable<T>
    {
        //1 метр = 39,3701 дюйм
        public T num;
        public Inch(T num)
        {
            this.num = num;
        }

        //унарный оператор +
        public static Inch<T> operator +(Inch<T> a) => new Inch<T>(Sum(a.num, 1.0));

        //унарный оператор -
        public static Inch<T> operator -(Inch<T> a) => new Inch<T>(Minus(a.num, 1.0));

        //бинарный оператор +
        public static Inch<T> operator +(Inch<T> a, Inch<T> b)
        {
            return new Inch<T>(Sum(a.num, b.num));
        }
        public static Inch<T> operator +(Inch<T> a, Meter<T> b) => new Inch<T>(Sum(a.num, Multiply(b.num, 39.3701)));
        public static Inch<T> operator +(Meter<T> b, Inch<T> a) => new Inch<T>(Sum(a.num, Multiply(b.num, 39.3701)));

        //бинарный оператор -
        public static Inch<T> operator -(Inch<T> a, Inch<T> b) => new Inch<T>(Minus(a.num, b.num));

        //умножение используется для перевода метров в дюймы
        public static Inch<T> operator -(Meter<T> a, Inch<T> b) => new Inch<T>(Minus(Multiply(a.num, 39.3701), b.num));
        public static Inch<T> operator -(Inch<T> b, Meter<T> a) => new Inch<T>(Minus(Multiply(a.num, 39.3701), b.num));

        //бинарный оператор *
        public static Inch<T> operator *(Inch<T> a, Inch<T> b) => new Inch<T>(Multiply(a.num, b.num));
        public static Inch<T> operator *(Inch<T> a, Meter<T> b) => new Inch<T>(Multiply(a.num, Multiply(b.num, 39.3701)));
        public static Inch<T> operator *(Meter<T> b, Inch<T> a) => new Inch<T>(Multiply(a.num, Multiply(b.num, 39.3701)));

        //бинарный оператор /
        public static Inch<T> operator /(Inch<T> a, Inch<T> b) => new Inch<T>(Divide(a.num, b.num));
        public static Inch<T> operator /(Inch<T> a, Meter<T> b) => new Inch<T>(Divide(a.num, Multiply(b.num, 39.3701)));
        public static Inch<T> operator /(Meter<T> b, Inch<T> a) => new Inch<T>(Divide(Multiply(b.num, 39.3701), a.num));

        //операторы сравнения
        public static bool operator ==(Inch<T> a, Inch<T> b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(Inch<T> a, Inch<T> b)
        {
            return !Equals(a, b);
        }

        public static bool operator >(Inch<T> a, Inch<T> b)
        {
            return CompareMore(a.num, b.num);
        }

        public static bool operator <(Inch<T> a, Inch<T> b)
        {
            return CompareLess(a.num, b.num);
        }

        public static bool operator >=(Inch<T> a, Inch<T> b)
        {
            return CompareMore(a.num, b.num) || Equals(a, b);
        }

        public static bool operator <=(Inch<T> a, Inch<T> b)
        {
            return CompareLess(a.num, b.num) || Equals(a, b);
        }

        private static bool Equals(T a, T b)
        {
            return ((dynamic)a == (dynamic)b);
        }

        private static bool CompareMore(T a, T b)
        {
            return ((dynamic)a > (dynamic)b);
        }

        private static bool CompareLess(T a, T b)
        {
            return ((dynamic)a < (dynamic)b);
        }

        //методы для действий суммирования, вычитания, умножения, деления типов и т.д.
        private static T Sum(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        private static T Sum(T a, double b)
        {
            return (dynamic)a + (dynamic)b;
        }

        private static T Minus(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }

        private static T Minus(T a, double b)
        {
            return (dynamic)a - (dynamic)b;
        }

        private static T Multiply(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }

        private static T Multiply(T a, double b)
        {
            return (dynamic)a * (dynamic)b;
        }

        private static T Divide(T a, T b)
        {
            return (dynamic)a / (dynamic)b;
        }

        //перегруженные методы
        public override string ToString() => $"{num}";

        public override bool Equals(object obj)
        {
            if (obj is Meter<T> objectType)
            {
                return Equals(this.num, objectType.num);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
