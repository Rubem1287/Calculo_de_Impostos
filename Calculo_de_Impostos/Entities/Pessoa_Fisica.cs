using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Calculo_de_Impostos.Entities
{
    class Pessoa_Fisica : Pessoa
    {
        public double DespesasMedicas { get; set; }

        public double Total_Impostos { get; set; }

        public Pessoa_Fisica()
        {

        }

        public Pessoa_Fisica(double despesasMedicas, string nome, double despesasAnual, double valor) : base(nome, despesasAnual)
        {
            DespesasMedicas = despesasMedicas;
            Total_Impostos = valor;

        }

        public double Calculo_Despesas(double despesas_anual, double despesas_medicas)
        {
            

            if(despesas_anual < 20000.00)
            {
                Total_Impostos = despesas_anual * 0.15;
                Total_Impostos = Total_Impostos - (despesas_medicas / 2);
            }
            else
            {
                Total_Impostos = despesas_anual * 0.25;
                Total_Impostos = Total_Impostos - (despesas_medicas / 2);
            }

            
            return Total_Impostos;
        }

       


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Nome+" : $ "+Total_Impostos.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();


        }


    }
}
