using System;
using System.Collections.Generic;
using System.Text;

namespace ExcClasseAbstrataTwo.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double DespesasMedicas { get; set; }

        public PessoaFisica(double despesasMedicas, string nome, double rendaAnual) : base  (nome, rendaAnual)
        {
            DespesasMedicas = despesasMedicas;
        }

        public override double Taxa()
        {

            double imposto;
           if(RendaAnual < 20000.00)
            {
                imposto = RendaAnual * 0.15;
                
            }
           else
            {
                imposto = RendaAnual * 0.25;
            }

           if (DespesasMedicas != 0)
            {
                imposto -= DespesasMedicas * 0.50;
            }

            return imposto;
        }
    }
}
