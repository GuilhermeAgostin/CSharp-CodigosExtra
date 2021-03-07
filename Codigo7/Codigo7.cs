using System;

class Veiculo // Classe base
{
   public int rodas;
   public int velmax;
   public bool ligado;

   // Metodo sem retorno
   public void ligar(){ligado = true;}

   public void desligar(){ligado = false;}

   // Metodo para retornar se ligado ou nao
   public string getLigado()
   {
    if (ligado)
    {
        return "esta ligado";
    }
    else
    {
        return "não esta ligado";
    }
   }
}

class Carro:Veiculo // A classe derivada herda a classe base e tambem seus elemetos
{
  public string nome;
  public string cor;

  public Carro(string nome, string cor)
  {
      desligar(); 
      rodas = 4; 
      velmax = 120; 
      this.nome=nome;
      this.cor = cor;     
  }
}

class Codigo7
{
    static void Main()
    {
        Carro c1=new Carro("Corsa", "Prata");

        Console.WriteLine("Cor : {0}",c1.cor);
        Console.WriteLine("\nNome : {0}",c1.nome);
        Console.WriteLine("\nRodas : {0}",c1.rodas);
        Console.WriteLine("\nVelocidade Máxima : {0}",c1.velmax);
        Console.WriteLine("\nO carro {0}.", c1.getLigado());
        Console.ReadKey(); 
    }
}




