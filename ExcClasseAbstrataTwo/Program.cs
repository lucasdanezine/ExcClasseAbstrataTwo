using System;
using ExcClasseAbstrataTwo.Entities;
using System.Collections.Generic;
using System.Globalization;
/*
 Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
bem como o total de imposto arrecadado.

Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica
são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as
seguintes:

Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com
renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50%
destes gastos são abatidos no imposto.
Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
fica: (50000 * 25%) - (2000 * 50%) = 11500.00

Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
funcionários, ela paga 14% de imposto.
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
400000 * 14% = 56000.00
 */
namespace ExcClasseAbstrataTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de contribuintes: ");
            int nContribuit = int.Parse(Console.ReadLine());

            List<Contribuinte> contribuinte = new List<Contribuinte>();
            double rendaAnual;

            for (int i=1; i <= nContribuit; i++)
            {
                Console.WriteLine($"Dados do Contribuinte #{i}:");
                Console.Write("PF ou PJ? (PF/PJ)? ");
                string tipoPessoa = Console.ReadLine();
                
                if(tipoPessoa == "PF")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda anual: ");
                    rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Despesas médicas: ");
                    double despesasMedicas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    contribuinte.Add(new PessoaFisica(despesasMedicas, nome, rendaAnual));

                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda anual: ");
                    rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Número de funcionários: ");
                    int numeroFunc = int.Parse(Console.ReadLine());

                    contribuinte.Add(new PessoaJuridica(numeroFunc, nome, rendaAnual));
                }
                
            }
            double soma = 0;
            Console.WriteLine("Imposto pago");
            foreach(Contribuinte contribuinte1 in contribuinte)
            {
                Console.WriteLine(contribuinte1.Nome + " $ " +contribuinte1.Taxa().ToString("F2",CultureInfo.InvariantCulture));
                soma += contribuinte1.Taxa();
            }

            Console.WriteLine("Soma total de taxas pagas: $" + soma.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
