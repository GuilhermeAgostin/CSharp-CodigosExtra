# Códigos Extra

Códigos desenvolvidos com base nos repositórios: Introdução, Tratamento de Dados, Operadores e Instruções de Decisão, Matrizes e Instruções de Repetição, e um pouco sobre o recurso Herança na linguagem C#.

### Herança

Herança é um dos atributos fundamentais da programação orientada a objeto. Ela permite definir uma classe filha que reutiliza (herda), estende ou modifica o comportamento de uma classe pai. A classe cujos membros são herdados é chamada de classe base. A classe que herda os membros da classe base é chamada de classe derivada.
Exemplo:

```C#
public class A
{
    public void Method1()
    {
        // Implementacao do metodo
    }
}

public class B : A
{ }

public class Example
{
    public static void Main()
    {
        B b = new B();
        b.Method1();
    }
}
```
