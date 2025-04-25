using System;

class A
{
    private int a = 5;
    private int b = 10;

    public int c
    {
        get { return a + b; }
    }

    public A() { }
}

class B : A
{
    private int d = 15;

    public int c2
    {
        get
        {
            int result = c + d; 
            return result > 20 ? result : 0; 
        }
    }

 
    public B() : base() { }

    public B(int dValue) : base()
    {
        d = dValue;
    }
}

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine($"Значение свойства c класса A: {a.c}");
       
        B b1 = new B();
        Console.WriteLine($"Значение свойства c2 класса B (по умолчанию): {b1.c2}");

        B b2 = new B(25);
        Console.WriteLine($"Значение свойства c2 класса B (собственный конструктор): {b2.c2}");
    }
}