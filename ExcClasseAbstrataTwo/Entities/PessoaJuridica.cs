using System;
using System.Collections.Generic;
using System.Text;

namespace ExcClasseAbstrataTwo.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int QtdFuncionarios { get; set; }

        public PessoaJuridica(int qtdFuncionarios, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            QtdFuncionarios = qtdFuncionarios;
        }

        public override double Taxa()
        {
            double imposto;
            
            if(QtdFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
            {
                imposto = RendaAnual * 0.16;
            }

            return imposto;
        }
    }
}
