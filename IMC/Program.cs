using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de IMC - Índice de Massa Corporal");

        // Solicita ao usuário o peso em quilogramas e a altura em metros
        Console.Write("Digite o peso (em kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        // Calcula o IMC
        double imc = CalcularIMC(peso, altura);

        // Exibe o resultado
        Console.WriteLine($"Seu IMC é: {imc:F2}");

        // Classifica o IMC
        ClassificarIMC(imc);

        // Aguarda a entrada do usuário para fechar o programa
        Console.ReadLine();
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static void ClassificarIMC(double imc)
    {
        if (imc < 18.5)
            Console.WriteLine("Você está abaixo do peso.");
        else if (imc < 24.9)
            Console.WriteLine("Seu peso está dentro da faixa saudável.");
        else if (imc < 29.9)
            Console.WriteLine("Você está com sobrepeso.");
        else if (imc < 34.9)
            Console.WriteLine("Você está com obesidade grau I.");
        else if (imc < 39.9)
            Console.WriteLine("Você está com obesidade grau II.");
        else
            Console.WriteLine("Você está com obesidade grau III.");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

