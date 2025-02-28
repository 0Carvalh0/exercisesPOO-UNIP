using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        double valor, taxa;
        int numP = 24;

        Console.Write("Valor: ");
        valor = double.Parse(Console.ReadLine());

        Console.Write("Taxa: ");

        taxa = double.Parse(Console.ReadLine());

        double m, p;

        Calcula(valor, taxa, numP, out m, out p);

        Console.WriteLine("Montante = {0}", m);

        Console.WriteLine("Prestação = {0}", p);

        Console.WriteLine("Juros = {0}", Juros(m, valor));
    }

    private static void Calcula(double valor, double taxa, int n, out double montante, out double prestacao)
    {
        montante = valor * (1 + taxa * n);
        prestacao = montante / n;
    }

    private static double Juros(double m, double v)
    {
        return m - v;
    }
} 
