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

        public override double Taxa(double renda)
        {
            double imposto;
           if(renda < 20000.00)
            {
                imposto = renda * 0.15;
                
            }
            else
            {
                imposto = renda * 0.25;
            }

            if (DespesasMedicas != 0)
            {
                imposto -= DespesasMedicas;
            }

            return imposto;
        }
    }
}
