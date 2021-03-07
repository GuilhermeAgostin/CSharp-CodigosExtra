using System;

class Veiculo 
{
   private int rodas;
   public int velmax;
   public bool ligado;
   
   public Veiculo(int rodas){ this.rodas = rodas; }
   public void ligar(){ ligado = true; }
   public void desligar(){ ligado = false; }

   public string getLigado()
   {
    return(ligado ? "está ligado":"está desligado"); // Operador ternario
   }
    
   public int getRodas()
   {
     return rodas;
   }

   public void setRodas(int rodas)
   {
     if (rodas < 0)
     {
         this.rodas = 0;
     }
     else if (rodas > 10)
     {
         this.rodas = 0;
     }
     else
     {
       this.rodas = rodas;
     }
   }
}

class Carro:Veiculo 
{
  public string nome;
  public string cor;

  public Carro(string nome, string cor) : base(4) 
  {
      velmax = 120; 
      this.nome=nome;
      this.cor = cor;     
  }
}

class CarroCombate : Carro
{
  public int municao;

  public CarroCombate() : base ("Monstrão", "Verde")
  {
      municao = 100;
      velmax = 150;
      setRodas(6);
      desligar(); 
  }

}

class Codigo8
{
    static void Main()
    {
        Carro carro1=new Carro("Corsa", "Prata");

        CarroCombate carrocombate1=new CarroCombate();
        
        carro1.ligar(); 
        
        Console.WriteLine("Cor : {0}",carro1.cor);
        Console.WriteLine("\nNome : {0}",carro1.nome);
        Console.WriteLine("\nRodas : {0}",carro1.getRodas());
        Console.WriteLine("\nVelocidade Máxima : {0}",carro1.velmax);
        Console.WriteLine("\nO carro {0} ", carro1.getLigado()); 
        Console.WriteLine("\n--------------------------------------------");
        Console.WriteLine("\nCor : {0}",carrocombate1.cor);
        Console.WriteLine("\nNome : {0}",carrocombate1.nome);
        Console.WriteLine("\nRodas : {0}",carrocombate1.getRodas());
        Console.WriteLine("\nMunição total de : {0}", carrocombate1.municao);
        Console.WriteLine("\nVelocidade Máxima : {0}",carrocombate1.velmax);
        Console.WriteLine("\nO carro {0} ", carrocombate1.getLigado()); 
        Console.ReadKey();
    }
}