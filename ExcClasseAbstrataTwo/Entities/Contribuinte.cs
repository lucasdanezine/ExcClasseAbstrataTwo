using System;
using System.Collections.Generic;
using System.Text;

namespace ExcClasseAbstrataTwo.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Taxa();
            
    }
}
