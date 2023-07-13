using System;

public class Métodos_Array
{
    static void ain()
    {
        Array_Mtds teste = new Array_Mtds();
        teste.Array_SR();
        Console.ReadLine();
    }
}
public class Array_Mtds
{
    public void Array_Copy()
    {
        string[] Vetor_Principal = new string[3] { "Arroz", "Feijão", "Frango" };
        string[] Vetor_Secundario = new string[3];
        Array.Copy(Vetor_Principal, Vetor_Secundario, Vetor_Principal.Length);
        Console.WriteLine("Vetor Principal:");
        foreach (string p in Vetor_Principal)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("\nVetor Secundário:");
        foreach (string p in Vetor_Secundario)
        {
            Console.WriteLine(p);
        }
    }
    public void Array_get()
    {
        int[] Numero = new int[5] { 5, 3, 2, 6, 4 };
        Console.WriteLine("Maior índice: "+ Numero.GetUpperBound(0));
        Console.WriteLine("Menor índice: "+ Numero.GetLowerBound(0));
        Console.WriteLine("Quantos valores tem: "+ Numero.GetLongLength(0));
        Console.WriteLine("Valor do índice 3: " + Convert.ToInt32(Numero.GetValue(3)));
    }
    public void Array_I()
    {
        int[] Num = new int[6] { 5, 3, 2, 6, 4, 3};
        Console.WriteLine("Primeira posição do 3 no Array: {0} posição",Array.IndexOf(Num, 3));
        Console.WriteLine("Primeira posição do 3 no Array: {0} posição",Array.LastIndexOf(Num,3));
    }
    public void Array_SR()
    {
        int[] Num = new int[6] { 6, 1, 4, 5, 2, 3 };
        Console.WriteLine("Array Original:");
        foreach (int n in Num)
        {

            Console.Write("{0} |", n);
        }
        Array.Sort(Num);
        Console.WriteLine("\nArray Crescente:");
        foreach (int n in Num)
        {
            Console.Write("{0} |",n);
        }
        Console.WriteLine("\nArray Decrescente:");
        Array.Reverse(Num);
        foreach (int n in Num)
        {
            Console.Write("{0} |", n);
        }
        Num.SetValue(10, 2);
        Console.WriteLine("\nAdicionando Valor 10 na posição 2:");
        foreach (int n in Num)
        {
            Console.Write("{0} |", n);
        }
    }
}