using System;
using System.Globalization;
using Calculo_de_Impostos.Entities;
using System.Collections.Generic;

namespace Calculo_de_Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa valor_Total = new Pessoa();

            Console.Write("Digite o valor de contribuintes : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int c = 1;c <=n;c++)
            {
                Console.WriteLine($"Dados de Pagamento de Taxa #{c}");
                Console.Write("Pessoa Física ou Jurídica (f/j)?");
                char pessoa = char.Parse(Console.ReadLine());

                if(pessoa == 'f' || pessoa == 'F')
                {
                    Console.Write("Nome : ");
                    string nome = Console.ReadLine();
                    Console.Write("Despesas anuais : ");
                    double despesasAnuais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Depesas Médicas : ");
                    double despesasMedicas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    valor_Total = new Pessoa();
                    pessoas.Add(new Pessoa_Fisica(despesasMedicas, nome, despesasAnuais));
                }
                else
                {
                    Console.Write("Nome : ");
                    string nome = Console.ReadLine();
                    Console.Write("Despesas anuais : ");
                    double despesasAnuais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Número de funcionário : ");
                    int funcionario = int.Parse(Console.ReadLine());
                    valor_Total = new Pessoa();
                    pessoas.Add(new Pessoa_Juridica(funcionario, nome, despesasAnuais));
                }
                Console.WriteLine();



            }

            Console.WriteLine("Taxas Pagas : ");
            foreach(Pessoa lista in pessoas)
            {

                Console.WriteLine(lista);

            }

            

            Console.WriteLine("Total de Taxas Pagas"+valor_Total.ToString());
            



        }
    }
}
