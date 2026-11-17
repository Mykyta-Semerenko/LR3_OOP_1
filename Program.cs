
using System;

interface IParent
{
    string Info();
    void Metod1();
    void Metod2();
}

class Child1 : IParent, IComparable<Child1>
{
    double pole1; 
    double pole2; 

    public Child1(double salary)
    {
        pole1 = salary;
    }

    public string Info()
    {
        return $"Працівник на ставці: зарплата={pole1:F2} премія={pole2:F2}";
    }

    public void Metod1()
    {
    }

    public void Metod2()
    {
        pole2 = pole1 * 0.25;
    }

    public int CompareTo(Child1 other)
    {
        if (other == null) return 1;
        return pole1.CompareTo(other.pole1);
    }
}

class Child2 : IParent, IComparable<Child2>
{
    double pole1; 
    double pole2; 
    int pole3;   
    double pole4; 

    public Child2(int hours, double price)
    {
        pole3 = hours;
        pole4 = price;
    }

    public string Info()
    {
        return $"Погодинний працівник: годин={pole3} " +
               $"вартість години={pole4:F2} " +
               $"зарплата={pole1:F2} премія={pole2:F2}";
    }

    public void Metod1()
    {
        pole1 = pole3 * pole4;
    }

    public void Metod2()
    {
        pole2 = 2000;
    }

    public int CompareTo(Child2 other)
    {
        if (other == null) return 1;
        return pole1.CompareTo(other.pole1);
    }
}

class Child3 : IParent, IComparable<Child3>
{
    double pole1; 
    double pole2; 
    double pole5; 

    public Child3(double sales)
    {
        pole5 = sales;
    }

    public string Info()
    {
        return $"Працівник від продажів: сума продажу={pole5:F2} " +
               $"зарплата={pole1:F2} премія={pole2:F2}";
    }
    public void Metod1()
    {
        pole1 = pole5 * 0.10;
    }
    public void Metod2()
    {
        pole2 = pole1 * 0.20;
    }
    public int CompareTo(Child3 other)
    {
        if (other == null) return 1;
        return pole5.CompareTo(other.pole5);
    }
}
class Program
{
    static void Main(string[] args)
    {
        IParent[] mas = new IParent[5];

        Random o = new Random();

        double f, s;
        int k;
        for (int i = 0; i < 5; i++)
        {
            f = o.Next(1, 4);

            if (f == 1)
            {
                s = o.Next(15000, 30001);
                mas[i] = new Child1(s);
            }

            if (f == 2)
            {
                k = o.Next(80, 181);
                s = o.Next(100, 301);
                mas[i] = new Child2(k, s);
            }

            if (f == 3)
            {
                s = o.Next(10000, 100001);
                mas[i] = new Child3(s);
            }

            mas[i].Metod1();
            mas[i].Metod2();

            Console.WriteLine(mas[i].Info());
            Console.WriteLine();
        }
    }
}
