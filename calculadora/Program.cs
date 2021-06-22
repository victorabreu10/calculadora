using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double val1 = 0, val2 = 0;
            string opc = "";
          
            Operacoes op = new Operacoes();
            Console.WriteLine("//////////////CALCULADORA/////////////////");
            Console.WriteLine("////////////// DIGITE 1 PARA SOMAR////////");
            Console.WriteLine("////////////// DIGITE 2 PARA SUBTRAIR/////");
            Console.WriteLine("////////////// DIGITE 3 PARA MULTIPLICAR///");
            Console.WriteLine("/////////////// DIGITE 4 PARA DIVIDIR////");
            Console.WriteLine("/////////////// DIGITE S PARA SAIR DO PROGRAMA");

            opc = Console.ReadLine();
            switch (opc)
            {
                case "1":
                    Console.WriteLine("voce selecionou Operação soma");
                    Console.WriteLine("Digite o primeiro numero");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    val2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("resultado da soma é: " + op.Soma(val1,val2));
                    break;
                case "2":
                    Console.WriteLine("voce selecionou Operação subtração");
                    Console.WriteLine("Digite o primeiro numero");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    val2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("resultado da subtração é " + op.Subtracao(val1, val2));
                    break;
                case "3":
                    Console.WriteLine("voce selecionou Operação multiplicação");
                    Console.WriteLine("Digite o primeiro numero");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    val2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("resultado da multiplicação é: " + op.Multiplicacao(val1, val2));
                    break;
                case "4":
                    Console.WriteLine("voce selecionou Operação divisão");
                    Console.WriteLine("Digite o primeiro numero");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    val2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("resultado da divisão é: " + op.Divisao(val1, val2));
                    break;
                case "5":
                    Console.WriteLine("voce selecionou Opção s ");
                    Console.WriteLine("prgorama encerrado...");
                    break;
                   
                default:
                    Console.WriteLine("essa opção não existe");
                    break;
            }
            //Console.WriteLine("A soma dos numeros é: " + op.Soma(val1, val2).ToString());
            //Console.WriteLine("A Subtraçâo dos numeros é: " + op.Subtracao(val1, val2).ToString());
            //Console.WriteLine("A Multiplicação dos numeros é: " + op.Multiplicacao(val1, val2).ToString());
            //Console.WriteLine("A Divisão dos numeros é: " + op.Divisao(val1, val2).ToString());
            

            
            
            
            
            
            
            Console.ReadKey();
            
        }


    }
}
