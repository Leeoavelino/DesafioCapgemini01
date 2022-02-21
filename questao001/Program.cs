using System;
using System.Text;

namespace questao001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas da escada: ");

            var linha = int.Parse(Console.ReadLine());
            var resultado = new StringBuilder();

            for(int i = 1; i <= linha; i++)
            {
                string linhaAtual = string.Empty;
                for (int j = 0; j < i; j++)
                    linhaAtual += '*';

                resultado.AppendLine(linhaAtual.PadLeft(linha, ' '));
            }

            Console.WriteLine(resultado.ToString());


            Console.WriteLine("Obrigado!");

        }
    }
}
