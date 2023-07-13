using System;

public class Funções
{
    static void ain()
    {
        Console.Write("Hello Word");
        Console.ReadLine();
    }
}
public class Algumas_Funcoes_Estruturas
{
    public void Ler_Teclado()
    {
        int idade; string nome; float salario;
        Console.Write("Digite sua Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite seu salário: ");
        salario = float.Parse(Console.ReadLine());
        Console.WriteLine("\nOlá {0}, sua idade cadastrada é {1} e seu salário é {2:c}", nome, idade, salario);
    }
    public void C_Porcen()
    {
        const float porcentagem = 0.12f; const String produto = "Macarrão"; float salario, conta;
        Console.Write("Salário: ");
        salario = Convert.ToInt32(Console.ReadLine());
        conta = salario * porcentagem;
        Console.WriteLine("O produto {0} vai custa {1:c}({2:p} do Salário de{3:c})", produto, conta, porcentagem, salario);

    }
    public void Condicional()
    {
    Inicio:
        int idade; string nome;
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade, não está apto a trabalhar pesado.");

        }
        else if (idade >= 60)
        {
            Console.WriteLine("Você já está na hora de se aposentar.");
        }
        else { Console.WriteLine("Você é maior de idade, já pode trabalhar."); }
        goto Inicio;
    }
    public void repeti()
    {
        for (int cont = 1; cont < 11; cont++)
        {
            Console.WriteLine("Número: " + cont);

        }
    }
}
