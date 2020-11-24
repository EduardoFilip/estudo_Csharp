//modulos ou pacotes //

using System; // C sharp manipular coisas do SO do usuario (datas, console, programas) //
using System.Collections.Generic; // Estruturas de dados //
using System.Linq; // Trabalhar com muitos dados //
using System.Text; // ferramentas para trabalhar com textos //


namespace c_
{
    class Program//inicio do programa //
    {



        static void Main(string[] args)//função principal //
        {
            
            double valor1, valor2, valor3, valor4, media;

            Console.WriteLine("Calculo de media");
            Console.WriteLine("Digite sua nota 1:");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua nota 2:");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua nota 3:");
            valor3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua nota 4:");
            valor4 = Convert.ToDouble(Console.ReadLine());

            media = (valor1 + valor2 + valor3 + valor4)/4;

            if (media < 70)
            {
                Console.WriteLine("Infelizmente voce foi reprovado.");

            }
            else
            {
                Console.WriteLine("Parabéns, voce foi aprovado!");
            }

            Console.WriteLine($"Sua media é.: {media}");




            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }// fim do programa//
}