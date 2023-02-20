using System;

namespace Teste01
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado01 = 0, lado02 = 0, lado03 = 0;
            string msg;

            Console.WriteLine("Vamos verificar se os três valores informados representam os lados de um tringulo");

            Console.WriteLine("Informe o valor do primeiro lado do triangulo");
            lado01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do segundo lado do  triângulo");
            lado02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor do terceiro lado do  triângulo");
            lado03 = Convert.ToInt32(Console.ReadLine());

            if ((lado01 < lado02 + lado03) && (lado02 < lado01 + lado03) && (lado03 < lado01 + lado02))
            {
                Console.WriteLine (msg = "Os valores informados representam um triângulo");
            }
            else 
            {
                Console.WriteLine (msg = "Triangulo Inválido");
            }

            Console.ReadKey();


        }
    }
}
