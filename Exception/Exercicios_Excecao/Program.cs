using System;

namespace Exercicios_Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();

            try
            {

                Console.WriteLine("--- Calculadora ---");
                Console.Write("Digite um número: ");
                string x = Console.ReadLine();
                Console.Write("Digite outro número: ");
                string y = Console.ReadLine();
                Console.Write("Escolha a operação: +, -, *, /");
                string op = Console.ReadLine();
                decimal resultado;

                var xDec = decimal.Parse(x);
                var yDec = decimal.Parse(y);

                switch (op)
                {
                    case "+":
                        resultado = calc.Somar(xDec, yDec);
                        Console.WriteLine(resultado);
                        break;
                    case "-":
                        resultado = calc.Subtrair(xDec, yDec);
                        Console.WriteLine(resultado);
                        break;
                    case "*":
                        resultado = calc.Multiplicar(xDec, yDec);
                        Console.WriteLine(resultado);
                        break;
                    case "/":
                        resultado = calc.Dividir(xDec, yDec);
                        Console.WriteLine(resultado);
                        break;

                    default:
                        throw new InvalidOperationException();
                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Digite apenas números.");
            }
            finally
            {
                Console.WriteLine("Operação finalizada");
            }

            ////////////////////////////////////

            //bool ValidarCPF(string Cpf)
            //{

            //    if (string.IsNullOrWhiteSpace(Cpf))
            //        return false;

            //    if (Cpf.Length != 11)
            //        return false;

            //}

            try
            {
                Console.WriteLine("--- Validador de CPF ---");
                Console.Write("Digite seu CPF: ");
                string Cpf = Console.ReadLine();

                Console.WriteLine("CPF Válido!");
                ValidarCPF(Cpf);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("CPF não pode ser nulo.");
            }
            finally
            {

            }




               


        }












    }


}








