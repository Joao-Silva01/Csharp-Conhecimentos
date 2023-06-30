using System;


public class Programa
{
    static void Main()
    {
        Console.WriteLine("Tipos_e_Variaveis");
        Tipos_e_Variaveis inf = new Tipos_e_Variaveis();
        inf.V_ar();
        Console.WriteLine("=================================================");
        Algumas_Funcoes_Estruturas informação = new Algumas_Funcoes_Estruturas();
        informação.C_Porcen();
        Console.ReadLine();
    }
}
public class Tipos_e_Variaveis
{
    public void Hello_World()
    {
        string hell, wor;// retorna só letras
        hell = "Hello";
        wor = "World";
        Console.WriteLine("Formatação: {0}, {1}", hell, wor);
    }
    public void T_F()
    {
        bool Vivo, Morto; //Só retorna true e false
        Vivo = true;
        Morto = false;
        Console.WriteLine("Tipos boleanos: {0}-----{1}", Vivo, Morto);
    }
    public void Uma_Letra()
    {
        char O; // Só retorna uma palavra com aspas simples
        O = 'J';
        Console.WriteLine(O);
    }
    public void Numero_inteiro()
    {
        int num1, num2, conta1, conta2;
        num1 = 10;
        num2 = 2;
        conta1 = (num1 + num2) * 2;
        conta2 = (num2 / 2 * num2) + 10;
        Console.WriteLine("Conta:\t{0}\nConta:\t{1}", conta1, conta2);
    }
    public void Numero_decimal()
    {
        float n1, n2;
        n1 = 5;
        n2 = 2;
        Console.WriteLine("Divisão: {0} / {1} =" + n1 + n2, n1, n2);
    }
    public void V_ar()
    {
        var nome_produto = "Feijão";
        var Anovencimento_produto = 2004;
        var preco_produto = 13.78f;
        Console.WriteLine("|Produto: {0}|Preço: {1}|Vencimento: {2}|",nome_produto, Anovencimento_produto, preco_produto);
    }
}
public class Algumas_Funcoes_Estruturas 
{ 
    public void Ler_Teclado() 
    {
        int idade; string nome;float salario;
        Console.Write("Digite sua Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite seu salário: ");
        salario = float.Parse(Console.ReadLine());
        Console.WriteLine("\nOlá {0}, sua idade cadastrada é {1} e seu salário é {2:c}",nome, idade, salario); 
    }
    public void C_Porcen() 
    {
       
    }
}
    
