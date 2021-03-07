using System;

class Codigo2
{
    static void Main()
    {
        int num1,num2,r;
        Console.WriteLine("Digite os números para que seja calculado a soma");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        r = soma(num1, num2); 
        Console.WriteLine("A soma de {0} e {1} é {2}", num1, num2, soma(num1, num2));
        Console.ReadKey();
    }

    static int soma(int n1,int n2)
    {
        int res = n1 + n2;
        return res;
    }
}