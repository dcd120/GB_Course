using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NikolayTools;

namespace HW3
{
    /*
    3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
    Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    Написать программу, демонстрирующую все разработанные элементы класса.
    Добавить свойства типа int для доступа к числителю и знаменателю;
    Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
    ** Добавить проверку, чтобы знаменатель не равнялся 0. 
    *Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
    **** Добавить упрощение дробей.
    Достаточно решить 2 задачи. Все программы сделать в одном решении.
    */
    internal class Fractions
    {
        int nu;
        int de;
        double dec;

        static public Fractions Simplefy(Fractions x)
        { 
            int NOD = EasyTools.NOD(x.nu, x.de);
            Fractions y = new Fractions(x.nu / NOD, x.de / NOD);
            return y;
        }
        static public Fractions Sum(Fractions x, Fractions y)
        {
            Fractions C = new Fractions(x.Nu* y.De + y.Nu*x.De,x.De*y.De);
            return C;
        }
        static public Fractions Minus(Fractions x, Fractions y)
        {
            Fractions C = new Fractions(x.Nu * y.De - y.Nu * x.De, x.De * y.De);
            return C;
        }

        static public Fractions Multi(Fractions x, Fractions y)
        {
            Fractions C = new Fractions(x.Nu * y.Nu, x.De * y.De);
            return C;
        }

        static public Fractions Div(Fractions x, Fractions y)
        {
            Fractions C = new Fractions(x.Nu * y.De, x.De * y.Nu);
            return C;
        }
        public Fractions()
        { 
            nu = 1;
            de = 1;
        }
        public override string ToString()
        {
            return $" {nu} // {de} ";
        }
        public Fractions(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
            else
            {
                this.nu = numerator;
                this.de = denominator;
            }
        }
        public int Nu            
        { 
            get { return nu; }
            set { nu = value; }
        }
        public double Dec
        {
            get { return (double) nu / de; }
        }
        public int De 
        { 
            get { return de; }
            set 
            {
                if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                else
                {
                    de = value;
                }
            }
        }

    }
}
