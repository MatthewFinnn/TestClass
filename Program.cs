using System;

public class Test
{
    public static void Main()
    {
        double k = 1.8;
        Worker w1 = new Worker();
        w1.Display();
        w1.SetRank(k);
        w1.Display();
        Worker w2 = new Worker("Джон Сноу", 350, 1.1);
        w2.Display();

        Manager m1 = new Manager();
        m1.Display();
        Manager m2 = new Manager("Джон Доу", 350, 1200);
        m2.Display();

        Engineer e1 = new Engineer();
        e1.Display();
        Engineer e2 = new Engineer("Дон Доу", 300, 10);
        e2.Display();

        Console.ReadKey();
    }
}

class Worker
{
    private int p;
    private string name;
    private double k;
    public Worker()
    {
        name = "Александр";
        p = 330;
        k = 1;
    }
    public Worker(string _name, int _p)
    {
        name = _name;
        p = _p;
        k = 1;
    }
    public Worker(string _name, int _p, double _k) : this(_name, _p)
    {
        k = _k;
    }

    public void SetRank(double _k)
    {
        k = _k;
    }

    public virtual double GetMoney()
    {
        return p * k;
    }

    public virtual void Display()
    {
        Console.WriteLine("Имя: " + name + "\t Доход: " + GetMoney());
    }
}




class Manager : Worker
{
    private int V;
    public Manager()
        : base()
    {
        V = 0;
    }
    public Manager(string _name, int _p)
        : base(_name, _p)
    {
        V = 0;
    }
    public Manager(string _name, int _p, int _V)
        : base(_name, _p)
    {
        V = _V;
    }
    public void SetV(int _V)
    {
        V = _V;
    }
    public override double GetMoney()
    {
        int H = 1000;
        if (V > H)
            return base.GetMoney() + 0.01*H;
        else
            return base.GetMoney();
    }

}

class Engineer : Worker
{
    private int n;

    public Engineer()
        : base()
    {
        n = 0;
    }
    public Engineer(string _name, int _p)
        : base(_name, _p)
    {
        n = 0;
    }
    public Engineer(string _name, int _p, int _n)
        : base(_name, _p)
    {
        n = _n;
    }
    public void SetN(int _n)
    {
        n = _n;
    }
    public override double GetMoney()
    {
        return base.GetMoney() + 4.8 * n;
    }
}