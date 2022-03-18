using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Este é um programa que calcula a média do aluno solicitando 4 notas e diz se o aluno foi aprovado conforme as condições");

            //solicita o valor da nota 1 e o usuário insere
            Console.Write(" \n Olá! Insira o valor da nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            //solicita o valor da nota 2 e o usuário insere
            Console.Write(" \n Agora insira o valor da nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            //solicita o valor da nota 3 e o usuário insere
            Console.Write(" \n Insira o valor da nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            //solicita o valor da nota 4 e o usuário insere
            Console.Write(" \n Insira o valor da nota 4: ");
            nota4 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            //estrutura condicional onde >=7 = aprovado <7 = reprovado
            if(media >= 7.0)
            {
                Console.WriteLine(" \n O aluno foi aprovado \n ");
            }
            else
            {
                Console.WriteLine(" \n O aluno foi reprovado \n ");
            }

            Console.WriteLine(" \n A média das notas é: " + media);

            //encerra o programa
            Console.WriteLine(" \n Pressione qualquer tecla para encerrar o programa");
            Console.ReadKey();



        }
    }
}
