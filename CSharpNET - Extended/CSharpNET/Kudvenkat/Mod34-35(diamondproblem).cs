/* mod 34 problems of multiple class inheritance

using System;

public class A
{
    public virtual void print()
    {
        Console.WriteLine("A implementation");
    }
}

public class B : A
{
    public override void print()
    {
        Console.WriteLine("B implementation");
    }
}

public class C : A
{
    public override void print()
    {
        Console.WriteLine("C implementation");
    }
}

//compilation error will be thrown ,only for concept purpose
public class D : B,C
{

}

public class program
{
    public static void Main()
    {
        D d = new D();
        d.print(); // will it call class C method or B method. Hence giving to ambiguity
    }
}

//*/

/* mod 35 multiple class inheritance using interfaces

using System;

interface IA
{
     void Aprint();
}

public class A : IA
{
    public void Aprint()
    {
        Console.WriteLine("Amethod from class A");
    }

}

interface IB
{
    void Bprint();
}

public class B : IB
{
    public void Bprint()
    {
        Console.WriteLine("Bmethod from class B");
    }

}

public class C : IA,IB
{
    A a = new A();
    B b = new B();

    public void Aprint()
    {
        a.Aprint();
    }

    public void Bprint()
    {
        b.Bprint();
    }

}

public class Program
{
    public static void Main()
    {
        C c = new C();
        c.Aprint();
        c.Bprint();
    }
}

//*/
