using System;

public class Jogador
{
  public int energia;
  public bool vivo; 
  public string nome; 

    // Sobrecarga de contrutores 

    // Construtor1
    public Jogador() 
    {
      energia = 100;
      vivo = true;
      nome="jose";
    }

    // Construtor2
    public Jogador(string n, int e, bool v)
    {
      energia = e;
      vivo = v;
      nome=n;
    }

    public void info() // Metodo sem parametro 
    {
      Console.WriteLine("Nome do jogador    : {0}",nome);  
      Console.WriteLine("Energia do jogador : {0}",energia); 
      Console.WriteLine("Status do jogador  : {0}\n",vivo); 
      Console.ReadKey();
    }

}

class Codigo6
{
    static void Main()
    {
        // Parametro de entrada do objeto
        Jogador j1 = new Jogador(); 
        Jogador j2 = new Jogador("Guilherme", 50, false);

        j1.info();
        j2.info();       
    }
}