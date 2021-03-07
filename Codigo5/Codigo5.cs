using System;

public class Jogador  // Classe publica Jogador
{ 
  public int energia=100; // Propriedaddes da classe 
  public bool vivo=true;
}

class Codigo5
{
    static void Main()
    { 
        Jogador j1 = new Jogador(); // Instanciando um novo objeto da classe jogador com nome j1
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50; // Acessando e alterando uma propriedade publica 

        Console.WriteLine("Energia do jogador 1 : {0}",j1.energia);  
        Console.WriteLine("Energia do jogador 2 : {0}",j2.energia); 
        Console.ReadKey();
    }
}