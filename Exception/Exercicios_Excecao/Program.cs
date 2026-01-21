using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Exercicios_Excecao
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calculadora com Tratamento de Exceções

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

            ////////////////////////////////////////////////////////////////////////////////////

            // Validador de CPF

            bool ValidarCPF(string Cpf)
            {

                if (string.IsNullOrWhiteSpace(Cpf))
                    throw new ArgumentNullException("O CPF não pode estar vazio.");

                if (Cpf.Length != 11)
                    throw new ArgumentException("O CPF deve ter exatamente 11 dígitos.");
                return true;
            }

            try
            {
                Console.WriteLine("--- Validador de CPF ---");
                Console.Write("Digite seu CPF: ");
                string Cpf = Console.ReadLine();

                ValidarCPF(Cpf);
                Console.WriteLine("CPF Válido!");
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Erro: {ex.ParamName}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operação finalizada.");

            }

            /////////////////////////////////////////////////////////////////////////////////////

            // Gerenciador de Arquivos com Finally

            
            void CopiarArquivo(string origem, string destino)
            {
                File.OpenRead(origem);
                File.Copy(origem, destino);

            }

            try
            {

                CopiarArquivo("origem.txt", "destino.txt");
                Console.WriteLine("Sucesso");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Arquivo não encontrado: {ex.Message}");

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Acesso negado ao arquivo: {ex.Message}");
            }
            catch (IOException ex) //input/output exception
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Chegou aqui");
            }

            /////////////////////////////////////////////////////////////////////////////////////

        }

    }

}








