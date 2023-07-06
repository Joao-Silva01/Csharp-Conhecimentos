using System;


public class Programa
{
    static void Main()
    {
        Tipos_e_Variaveis teste1 = new Tipos_e_Variaveis();
        teste1.V_ar();
        Console.WriteLine("=================================================");
        Algumas_Funcoes_Estruturas teste2 = new Algumas_Funcoes_Estruturas();
        teste2.repeti();
        Console.WriteLine("=================================================");
        Etc teste3 = new Etc();
        int subtração, soma, multi, divi;
        soma = teste3.Out(6,2, out subtração, out multi, out divi);
        Console.WriteLine("6 + 2 = {0}\n6 - 2 = {1}\n6 x 2 = {2}\n6 / 2 = {3}", soma, subtração, multi, divi);
        Console.WriteLine("=================================================");
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
       const float porcentagem = 0.12f; const String produto = "Macarrão"; float salario, conta;
        Console.Write("Salário: ");
        salario = Convert.ToInt32(Console.ReadLine());
        conta = salario * porcentagem;
        Console.WriteLine("O produto {0} vai custa {1:c}({2:p} do Salário de{3:c})",produto,conta, porcentagem, salario);
        
    }
    public void Condicional()
    {
        Inicio:
        int idade; string nome;
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        if(idade < 18)
        {
            Console.WriteLine("Você é menor de idade, não está apto a trabalhar pesado.");
            
        }
        else if(idade >= 60)
        {
            Console.WriteLine("Você já está na hora de se aposentar.");
        }
        else { Console.WriteLine("Você é maior de idade, já pode trabalhar."); }
            goto Inicio;
    }
    public void repeti()
    {
        for(int cont= 1; cont < 11; cont++)
        {
            Console.WriteLine("Número: " + cont);
            
        }
    }
}
public class Etc
{
    public void re()
    {
        string[] Comida = new string[3] {"Macarrão", "Feijão", "Arroz" };
        float[] Preco_comida = { 12.34f, 4.75f, 10.50f };
        for(int cont = 0; cont < Comida.Length; cont++) {
            Console.WriteLine("Produto: {0}  \tPreço: {1:c}", Comida[cont], Preco_comida[cont]);
        }
    }
    public void Cores()
    {
        int indice = 1;
        string[] cores = { "Azul", "Vermelho", "Amarelo", "Preto", "Rosa" };
        Inicio:
        foreach( string cor in cores)
        {
            Console.WriteLine("[{0}]Cor\t{1}",indice,cor);
            indice++;
        }
        Console.Write("Digite um índice:");
        int escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Você escolheu {0}", cores[0]);
                break;
            case 2:
                Console.WriteLine("Você escolheu " + cores[1]);
                break;
            case 3:
                Console.WriteLine("Você escolheu {0}", cores[2]);
                break;
            case 4:
                Console.WriteLine("Você escolheu " + cores[3]);
                break;
            case 5:
                Console.WriteLine("Você escolheu {0}", cores[4]);
                break;
            default:
                Console.WriteLine("Índice errado!");
                goto Inicio;
        }   
    }
    public int Out(int n1,int n2, out int subtracao, out int multiplica, out int divisao)
    {
        int soma;
        soma = n1 + n2 ;
        subtracao = n1 - n2;
        multiplica = n1 * n2;
        divisao = n1 / n2;
        return soma;
    }
}
    
