using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bem Vindo, escolha a opção desejada:\r\n 1) Calculadora\r\n 2) Sair\r\n");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:

                    Console.WriteLine("Digite o primeiro digito");
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo digito");
                    double num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(
                    " Agora escolha a operação:\r\n 1) Soma\r\n 2) multiplicaçao\r\n 3) subtração \r\n 4) Divisão\r\n");
                    int operacao = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (operacao)
                    {
                        case 1:
                            Console.WriteLine("a opção selecionada foi Soma\r\n ");
                            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("a opção selecionada foi multiplicação\r\n ");
                            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("a opção selecionada foi subtração\r\n ");
                            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                            Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("a opção selecionada foi Divisão\r\n ");
                            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Desculpa opção não encontrada\r\n Encerrando programa");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }
                    break;

                case 2:

                    Environment.Exit(0);
                    break;

                default:

                    Console.WriteLine("Desculpa opção não encontrada\r\nEncerrando programa");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
