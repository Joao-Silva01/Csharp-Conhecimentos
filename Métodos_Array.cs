using System;

public class Métodos_Array
{
    /*static void Main()
    {
        Console.ReadLine();
    }*/
}
public class Array_Mtds
{
    public void Arr_ay()
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
}