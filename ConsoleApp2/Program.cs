using System;
namespace ConsoleApp2
{
    //struct Dimensions
    //{
    //    private double Length;
    //    public double Width;

    //    public Dimensions(double length, double width)
    //    {
    //        Length = length;
    //        Width = width;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"Длина {Length}, ширина {Width}");
    //    }

    //}

    //class Student
    //{
    //    int _studentID;
    //    string _firstName = "John";
    //    string _lastName = "Doe";
    //    string _group;

    //    public void Print()
    //    {
    //        Console.WriteLine($"Студент {_firstName} {_lastName}");
    //    }

    //}



    class Fraction
    {
        private int numerator;
        private int denumerator;

        public Fraction(int numerator = 0, int denumerator = 0)
        {
            this.numerator = numerator;
            if (denumerator != 0)
            {
                this.denumerator = denumerator;
            }
            else
                this.denumerator = 1;
        }

        public void setdenumerator(int denumerator)
        {
            if (denumerator != 0)
            {
                this.denumerator = denumerator;
            }
            else
                this.denumerator = 1;
        }

        public void setnumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public int GetNumerator()
        {
            return numerator;
        }
        public int GetDenumerator()
        {
            return denumerator;
        }
        public void print()
        {
            Console.WriteLine($"{numerator} / {denumerator}");
        }

        public static Fraction Add(Fraction fobj1, Fraction fobj2)
        {
            Fraction fraction = new Fraction(fobj1.numerator * fobj2.denumerator + fobj2.numerator * fobj1.denumerator, fobj1.denumerator * fobj2.denumerator);
            return fraction;
        }

        public static Fraction operator + (Fraction fobj1, Fraction fobj2)
        {
            //Fraction fraction = new Fraction(); fraction.Add(fobj1, fobj2);
            return Add(fobj1, fobj2);
        }

        public static Fraction Sub( Fraction fobj1,  Fraction fobj2)
        {
            Fraction fraction = new Fraction((fobj1.numerator * fobj2.denumerator) - (fobj2.numerator * fobj1.denumerator), fobj1.denumerator * fobj2.denumerator);
            return fraction;
        }

        public static Fraction operator - (Fraction fobj1, Fraction fobj2)
        {
            return Sub(fobj1, fobj2);
        }


        public static Fraction Mult( Fraction fobj1,  Fraction fobj2)
        {
            Fraction fraction = new Fraction(fobj1.numerator * fobj2.numerator, fobj1.denumerator * fobj2.denumerator);
            return fraction;
        }

        public static Fraction operator *(Fraction fobj1, Fraction fobj2)
        {
            return Mult(fobj1, fobj2);

        }

        public static Fraction Div( Fraction fobj1,  Fraction fobj2)
        {
            Fraction fraction = new Fraction(fobj1.numerator * fobj2.denumerator, fobj2.numerator * fobj1.denumerator);
            return fraction;
        }
        public static Fraction operator /(Fraction fobj1, Fraction fobj2)
        {
            return Div(fobj1, fobj2);
        }

        public static bool ravni( Fraction fobj1,  Fraction fobj2)
        {
            if ((fobj1.denumerator * fobj2.denumerator) == (fobj1.numerator * fobj2.numerator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool neravni(Fraction fobj1, Fraction fobj2)
        {
            if ((fobj1.denumerator * fobj2.denumerator) != (fobj1.numerator * fobj2.numerator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator == (Fraction fobj1, Fraction fobj2)
        {
            return ravni(fobj1, fobj2);
        }

        public static bool operator !=(Fraction fobj1, Fraction fobj2)
        {
            return neravni(fobj1, fobj2);
        }

        public static bool bolse( Fraction fobj1,  Fraction fobj2)
        {
            if ((fobj1.denumerator * fobj2.denumerator) > (fobj1.numerator * fobj2.numerator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Fraction fobj1, Fraction fobj2)
        {
            return bolse(fobj1, fobj2);
        }

        public static bool menche( Fraction fobj1,  Fraction fobj2)
        {
            if ((fobj1.denumerator * fobj2.denumerator) < (fobj1.numerator * fobj2.numerator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Fraction fobj1, Fraction fobj2)
        {
            return menche(fobj1, fobj2);
        }

        public static bool bolseiliravni( Fraction fobj1,  Fraction fobj2)
        {
            if ((fobj1.denumerator * fobj2.denumerator) >= (fobj1.numerator * fobj2.numerator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Fraction fobj1, Fraction fobj2)
        {
            return bolseiliravni(fobj1, fobj2);
        }



        public static bool mencheiliravni( Fraction fobj1,  Fraction fobj2)
        {
            if ((fobj1.denumerator * fobj2.denumerator) <= (fobj1.numerator * fobj2.numerator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Fraction fobj1, Fraction fobj2)
        {
            return mencheiliravni(fobj1, fobj2);
        }

        public static Fraction plusplus( Fraction fobj1)
        {
            fobj1.numerator = fobj1.numerator + fobj1.denumerator;
            return fobj1;
        }

        public static Fraction operator ++(Fraction fobj1)
        {
            return plusplus(fobj1);
        }

        public static Fraction minysminys( Fraction fobj1)
        {
            fobj1.numerator = fobj1.numerator - fobj1.denumerator;
            return fobj1;
        }
        public static Fraction operator --(Fraction fobj1)
        {
            return plusplus(fobj1);
        }

        public static Fraction pow(Fraction fobj1, int n)
        {
            
            for (int i = 0; i < n-1; i++)
            {
                fobj1 = Mult(fobj1, fobj1);
            }

            return fobj1;

        }

        public static Fraction operator ^(Fraction fobj1, int step)
        {
            return pow(fobj1, step);
        }

        public static Fraction sqrt(Fraction fobj1)
        {
            Fraction f = new Fraction(Convert.ToInt32(Math.Sqrt(fobj1.numerator)), Convert.ToInt32(Math.Sqrt(fobj1.denumerator)));
            return f;
        }

        public static Fraction operator ~(Fraction fobj1)
        {
            return sqrt(fobj1);
        }

        public static Fraction Ne( Fraction fobj1)
        {
            Fraction fract = new Fraction();
            if (fobj1.numerator > 0)
            {
                fract.numerator = fobj1.denumerator;fract.denumerator = fobj1.numerator;
                return fract;
            }
            else
            {
                fract.numerator = fobj1.numerator; fract.denumerator = fobj1.denumerator;
                return fract;
            }
        }
        public static Fraction operator !(Fraction fobj1)
        {
            return Ne(fobj1);
        }
    }


    class Program
    {
         static void Main(string[] args)
         {

            //Dimensions dimensions = new Dimensions(7.342, 23.49);
            //dimensions.Print();
            //Student student1 = new Student();
            //student1.Print();
            //Student student2 = new Student();
            //student2.Print();

            Fraction fracton1 = new Fraction();
            fracton1 = new Fraction();
            Console.WriteLine("Введите первую дробь");
            Console.WriteLine("Введите числитель");
            int buff = Convert.ToInt32(Console.ReadLine());
            fracton1.setnumerator(buff);
            Console.WriteLine("Введите знаменатель");
            buff = Convert.ToInt32(Console.ReadLine());
            fracton1.setdenumerator(buff);

            Fraction fracton2 = new Fraction();
            Console.WriteLine("Введите вторую дробь");
            Console.WriteLine("Введите числитель");
            buff = Convert.ToInt32(Console.ReadLine());
            fracton2.setnumerator(buff);
            Console.WriteLine("Введите знаменатель");
            buff = Convert.ToInt32(Console.ReadLine());
            fracton2.setdenumerator(buff);

            Console.WriteLine("Первая дробь:");
            fracton1.print();
            Console.WriteLine("Вторая дробь:");
            fracton2.print();


            Console.WriteLine("Математические операции");
            Console.WriteLine("Сложение");
            Fraction fraction3 = new Fraction();
            //fraction3 = fraction3.Add(fracton1, fracton2);
            fraction3 = fracton1 + fracton2;

            fraction3.print();

            Console.WriteLine("Вычитание");
            fraction3 = new Fraction();
            //fraction3 = fraction3.Sub(fracton1, fracton2);
            fraction3 = fracton1 - fracton2;

            fraction3.print();

            Console.WriteLine("Умножение");
            fraction3 = new Fraction();
            //fraction3 = fraction3.Mult(fracton1, fracton2);
            fraction3 = fracton1 * fracton2;
            fraction3.print();

            Console.WriteLine("Деление");
            fraction3 = new Fraction();
            //fraction3 = fraction3.Div(fracton1, fracton2);
            fraction3 = fracton1 / fracton2;

            fraction3.print();


            Console.WriteLine("Лоигческие операции");

            if(fracton1 == fracton2)
            {
                Console.WriteLine("fraction1 == fraction2");
            }
            else
            {
                Console.WriteLine("fraction1 != fraction2");
            }

            if (fracton1 > fracton2) 
            {
                Console.WriteLine("fraction1 > fraction2");
            }
            else
            {
                Console.WriteLine("fraction1 < fraction2");
            }

            if (fracton1 < fracton2)
            {
                Console.WriteLine("fraction1 < fraction2");
            }
            else
            {
                Console.WriteLine("fraction1 > fraction2");
            }


            if (fracton1 >= fracton2)
            {
                Console.WriteLine("fraction1 >= fraction2");
            }
            else
            {
                Console.WriteLine("fraction1 <= fraction2");
            }

            if (fracton1 <= fracton2)
            {
                Console.WriteLine("fraction1 <= fraction2");
            }
            else
            {
                Console.WriteLine("fraction1 >= fraction2");
            }


            Console.WriteLine("Операции интримента и динкримента");
            //fracton1.plusplus(fracton1);
            fracton1 = fracton1++;
            fracton1.print();
            //fracton1.minysminys(fracton1);
            fracton1 = fracton1--;
            fracton1.print();

            Console.WriteLine("Перевнутая дробь");
            //fracton1.Ne(fracton1);
            fracton1 = !fracton1;
            fracton1.print();

            Console.WriteLine("Степень");
            fracton1 = fracton1 ^ 2;
            fracton1.print();
            Console.WriteLine("Корень");
            fracton1 = ~fracton1;
            fracton1.print();

         }

    }

}


