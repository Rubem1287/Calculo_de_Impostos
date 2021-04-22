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

        public Pessoa_Fisica(double despesasMedicas, string nome, double despesasAnual) : base(nome, despesasAnual)
        {
            DespesasMedicas = despesasMedicas;

        }

        public Pessoa_Fisica(double valor_Total)
        {
            Valor_Total = valor_Total;
        }

        public double Calculo_Despesas()
        {
            Total_Impostos = 0;

            if(DespesaAnual < 20000.00)
            {
                Total_Impostos = DespesaAnual * 0.15;
                Total_Impostos = Total_Impostos - (DespesasMedicas / 2);
            }
            else
            {
                Total_Impostos = DespesaAnual * 0.25;
                Total_Impostos = Total_Impostos - (DespesasMedicas / 2);
            }

            Salvar_Dados(Total_Impostos);
            return Total_Impostos;
        }


        public void Salvar_Dados(double total_Impostos)
        {
            Valor_Total += Total_Impostos;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Nome+" : $ "+Calculo_Despesas().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();


        }


    }
}
