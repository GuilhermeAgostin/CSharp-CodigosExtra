using System;

class Codigo1
{
  static void Main()
  {
        int[] vetor1=new int [5];
        int[] vetor2=new int [5];
        int[] vetor3=new int [5];
        int[,] matriz=new int [2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random = new Random();
        for(int i=0; i<vetor1.Length;i++){
            vetor1[i]=random.Next(50);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.WriteLine("\n{0}",n);
        }

        Console.WriteLine("\nBinarySearch");
        int procurado=33;
        int pos=Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado,pos);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("\nCopy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        Console.WriteLine("\nCopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("GetLongLenght");
        long qtdeElementosVetor=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}",qtdeElementosVetor);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor=vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do vetor1 {0}",MenorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1 {0}",MaiorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int valor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("Indice do primeiro valor 3:{0}",indice1);
        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Indice do último valor 33:{0}",indice2);
        Console.WriteLine("-------------------------------------------");

        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine("\n{0}",n);
        }   

        vetor2.SetValue(99,0);
        for(int i=0;i<vetor2.Length;i++){
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("\nVetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("\nVetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.ReadKey();
  }
}



        