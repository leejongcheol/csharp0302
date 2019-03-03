using System;
class Emp {
    public int Empno { get; set; } = 999;
}
class EmpTest{
    static void Main()    {
        Emp e = new Emp();  e.Empno = 999;      int i = e.Empno;
        Console.WriteLine(e.Empno);
    }
}