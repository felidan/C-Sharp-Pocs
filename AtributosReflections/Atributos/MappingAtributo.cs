using System;

namespace AtributosReflections.Atributos
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    class MappingAtributo : Attribute
    {
        public MappingAtributo(string nome)
        {
            NomeColuna = nome;
        }

        public string NomeColuna { get; set; }
    }
}
