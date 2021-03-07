using System;

class Codigo3 
{
    static void Main()
    {
      int ValorASerDobrado = 10; 
      dobrar(ValorASerDobrado);
      Console.WriteLine(ValorASerDobrado);
      dobrar1(ref ValorASerDobrado); 
      Console.WriteLine(ValorASerDobrado);
      Console.ReadKey();
    }
    static void dobrar(int valor)
    {
        valor*=2;
    }
     static void dobrar1(ref int valor)
    {
        valor*=2;
    }
}