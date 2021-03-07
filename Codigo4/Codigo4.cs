using System;

class Codigo4
{
    static void Main()
    {
        int divid,divis,quoci,rest;
        divid=10;
        divis=3;

        quoci=divisao(divid,divis,out rest);

        Console.WriteLine("{0}/{1}={2} com resto = {3}", divid,divis,quoci,rest);
        Console.ReadKey();
    }
    static int divisao(int dividendo,int divisor,out int resto)
    {
        int quociente;
        quociente=dividendo/divisor;
        resto=dividendo%divisor;
        return quociente;
    }
}