using System;

namespace maiorEMenorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numerosDigitados, menorNumero, maiorNumero;
            //É criado três variáveis do tipo float
            int i;
            //E uma variável do tipo int

            //É informado o primeiro número fora do laço
            Console.WriteLine("Por favor, informe o 1º número: ");//É pedido para o usuário informar o número digitado
            numerosDigitados = float.Parse(Console.ReadLine());//numerosDigitados irá receber um número convertido para float
            //O primeiro recebimento de dados é feito fora do laço para maiorNumero e menorNumero receberem um valor
            maiorNumero = numerosDigitados;//maiorNumero irá receber o valor de numerosDigitados
            menorNumero = numerosDigitados;//menorNumero irá receber o valor de numerosDigitados

            for (i = 1; i < 15; i++)//Cria um laço de repetição que irá percorrer 15 posições
            {
                Console.WriteLine("Por favor, informe o {0}º número: ", i + 1);//É pedido para o usuário informar o número digitado
                numerosDigitados = float.Parse(Console.ReadLine());//numerosDigitados irá receber um número convertido para float
                if (numerosDigitados > maiorNumero)//Se numerosDigitados for maior que maior número
                {
                    maiorNumero = numerosDigitados;//maiorNumero irá receber numerosDigitados
                } else// Senão
                {
                    if (numerosDigitados < menorNumero)//numeroDigitado for menor que menorNumero
                    {
                        menorNumero = numerosDigitados;//menorNumero irá receber numerosDigitados
                    }
                }

            }
            Console.WriteLine("O maior número digitado foi: {0}", maiorNumero);//Será impresso o maior número digitado
            Console.WriteLine("O menor número digitado foi: {0}", menorNumero);//Será impresso o menor número digitado
            Console.ReadKey();
        }
    }
}
