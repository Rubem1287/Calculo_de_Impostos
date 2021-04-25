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


        public Pessoa_Juridica()
        {

        }

        public Pessoa_Juridica(int funcionarios, string nome, double despesasAnual, double valor) : base(nome, despesasAnual)
        {
            Funcionarios = funcionarios;
            Total_Impostos = valor;

        }

        public double Calculo_Despesas(double despesas_Anual, int funcionario)
        {
           

            if(funcionario > 10)
            {
                Total_Impostos = despesas_Anual * 0.14;
            }
            else
            {
                Total_Impostos = despesas_Anual * 0.16;
            }
            
            return Total_Impostos;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Nome + " : $ " + Total_Impostos.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();


        }

    }
}
