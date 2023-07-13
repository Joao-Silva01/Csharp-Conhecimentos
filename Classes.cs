using System;

class Classes 
{
    static void Main()
    {
        Menu menu = new Menu();
    }
}
class Menu
{
    
    public Menu()
    {
        men();
        escolha();
    }
    public void men()
    {
        Console.WriteLine("========= MENU DE CONTAS =========\n");
        string[] opcao_menu = { "1- Somar", "2- Subtrair", "3- Multiplicar", "4- Divisão", "5- Sair" };
        foreach(string op in opcao_menu)
            {
                Console.WriteLine(op);
            }
    }
    public void escolha()
    {
    Inicio:
        int n1, n2;
        Console.Write("\nEscolha uma opção:");
        int op = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("\n======= Escolheu a opção Somar =======");
                Contas Op_1 = new Contas();
                Console.Write("Digite o primeiro número:");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número:");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}",n1 ,n2 ,Op_1.Soma(n1, n2));
                goto Inicio;

            case 2:

                Console.WriteLine("\n======= Escolheu a opção Subtrair =======");
                Contas Op_2 = new Contas();
                Console.Write("Digite o primeiro número:");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número:");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} - {1} = {2}", n1, n2, Op_2.Subtrair(n1, n2));
                goto Inicio; 

            case 3:
                Console.WriteLine("\n======= Escolheu a opção Multiplicar =======");
                Contas Op_3 = new Contas();
                Console.Write("Digite o primeiro número:");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número:");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} x {1} = {2}", n1, n2, Op_3.Multiplicar(n1, n2));
                goto Inicio;

            case 4:
                Console.WriteLine("\n======= Escolheu a opção Divisão =======");
                Contas Op_4 = new Contas();
                Console.Write("Digite o primeiro número:");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número:");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} / {1} = {2}", n1, n2, Op_4.Divisao(n1, n2));
                goto Inicio;
            case 5:
                Console.WriteLine("\nSaindo do Programa...");
                break;

            default:
                Console.WriteLine("\nOpção inválida");
                goto Inicio;
        }
    }
}
class Contas
{
    public int Soma(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
    public int Divisao(int num1, int num2)
    {
        return num1 / num2;
    }
}
