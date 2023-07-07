using System;

public class Estruturas
{
    /*static void Main()
    {
        
    }*/
}
public class Etc
{
    public void re()
    {
        string[] Comida = new string[3] { "Macarrão", "Feijão", "Arroz" };
        float[] Preco_comida = { 12.34f, 4.75f, 10.50f };
        for (int cont = 0; cont < Comida.Length; cont++)
        {
            Console.WriteLine("Produto: {0}  \tPreço: {1:c}", Comida[cont], Preco_comida[cont]);
        }
    }
    public void Cores()
    {
        int indice = 1;
        string[] cores = { "Azul", "Vermelho", "Amarelo", "Preto", "Rosa" };
    Inicio:
        foreach (string cor in cores)
        {
            Console.WriteLine("[{0}]Cor\t{1}", indice, cor);
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
    public int Out(int n1, int n2, out int subtracao, out int multiplica, out int divisao)
    {
        int soma;
        soma = n1 + n2;
        subtracao = n1 - n2;
        multiplica = n1 * n2;
        divisao = n1 / n2;
        return soma;
    }
}
