using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Calculo_de_Impostos.Entities
{
    class Pessoa_Juridica : Pessoa
    {
        public int Funcionarios { get; set; }

        public double Total_Impostos { get; set; }


        public Pessoa_Juridica(int funcionarios, string nome, double despesasAnual) : base(nome, despesasAnual)
        {
            Funcionarios = funcionarios;

        }

        public double Calculo_Despesas()
        {
            Total_Impostos = 0;

            if(Funcionarios > 10)
            {
                Total_Impostos = DespesaAnual * 0.14;
            }
            else
            {
                Total_Impostos = DespesaAnual * 0.16;
            }
            Valor_Total += Total_Impostos;
            return Total_Impostos;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Nome + " : $ " + Calculo_Despesas().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();


        }

    }
}
