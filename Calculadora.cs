using System;

namespace calculadoraCSharp
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos calcular?");


            Console.WriteLine("Digite o primeiro numero: ");
            int numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numeroB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual operação você deseja fazer com estes numeros? ");
            Console.WriteLine("Digite 1 para Soma");
            Console.WriteLine("Digite 2 para Subtração");
            Console.WriteLine("Digite 3 para Divisão");
            Console.WriteLine("Digite 4 para Multiplicação");
            // Console.WriteLine("Digite 5 para retornar o resto da divisão");
            // Console.WriteLine("Digite 6 para elevar a potência");
            Console.WriteLine("Digite 0 para Sair");

            int operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                 case 1:
                    int Soma = (numeroA + numeroB);
                    Console.WriteLine("Resultado da Soma: " + Soma);
                    break;

                case 2:
                    int Subtracao = (numeroA - numeroB);
                    Console.WriteLine("Resultado da Subtração: " + Subtracao);
                    break;

                case 3:
                    if (numeroB != 0)
                    {
                        double Divisao = ((double)numeroA / numeroB);
                        Console.WriteLine("Resultado da Divisão: " + Divisao);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero.");
                    }
                    break;

                case 4:
                    int Multiplicacao = (numeroA * numeroB);
                    Console.WriteLine("Resultado da Multiplicação: " + Multiplicacao);
                    break;

                case 0:
                    Console.WriteLine("Saindo do programa.");
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }   

        }
   }
}
        