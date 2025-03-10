using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar entrada do usuário
        Console.Write("Digite uma string: ");
        string entrada = Console.ReadLine();

        // Inverter a string
        string invertida = InverterString(entrada);

        // Exibir a string invertida
        Console.WriteLine("String invertida: " + invertida);
    }

    static string InverterString(string texto)
    {
        // Converte a string em um array de caracteres
        char[] caracteres = texto.ToCharArray();

        // Inverte o array de caracteres
        Array.Reverse(caracteres);

        // Retorna a string invertida
        return new string(caracteres);
    }
}

/*

Entrada: Rodrigo

Saída: ogirdoR


*/