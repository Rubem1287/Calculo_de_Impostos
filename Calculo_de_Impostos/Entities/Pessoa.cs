using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Calculo_de_Impostos.Entities
{
    class Pessoa
    {
        public string Nome { get; set; }

        public double DespesaAnual { get; set; }

        public double Valor_Total { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(double valor_Total)
        {
            Valor_Total = valor_Total;
        }

        public Pessoa(string nome, double despesasAnual)
        {
            Nome = nome;
            DespesaAnual = despesasAnual;
        }


        public override string ToString()
        {
            return Valor_Total.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
