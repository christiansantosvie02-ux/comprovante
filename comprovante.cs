using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("=== RESTAURANTE SABOR E ARTE ===");

        Console.Write("Nome do garçom: ");
        string garcom = Console.ReadLine();

        double totalGeral = 0; // ADICIONADO

        for (int i = 1; i <= 2; i++)
        {
            double total = ProcessarPedido(i);

            totalGeral += total; // ADICIONADO (soma dos pedidos)

            ExibirComprovante(i, garcom, total);
        }

        // ADICIONADO (resultado final)
        Console.WriteLine("---------------------------");
        Console.WriteLine($"TOTAL DOS 2 PEDIDOS: R$ {totalGeral:F2}");
        Console.WriteLine("---------------------------");
    }

    static double ProcessarPedido(int numeroPedido)
    {
        Console.Write($"Pedido {numeroPedido} - quantos itens? ");
        int qtd = int.Parse(Console.ReadLine());

        double total = 0;

        for (int i = 1; i <= qtd; i++)
        {
            Console.Write($"Item {i}: R$ ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total += valor;
        }

        if (total > 80)
        {
            total *= 0.90; // desconto 10%
        }

        return total;
    }

    static void ExibirComprovante(int numero, string garcom, double total)
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine($"COMPROVANTE - Pedido {numero}");
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Garcom: {garcom}");
        Console.WriteLine($"Total: R$ {total:F2}");
        Console.WriteLine("---------------------------");
    }
}