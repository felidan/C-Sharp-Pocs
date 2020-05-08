using AtributosReflections.Atributos;
using System;
using System.ComponentModel.DataAnnotations;

namespace AtributosReflections.Model
{
    public class Proposta
    {
        [Required(ErrorMessage = "Campo Obrigatorio"), MappingAtributo("ID_PROPOSTA")]
        public int IdProposta { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio"), MappingAtributo("ID_STATUS")]
        public int IdStatus { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio"), MappingAtributo("DT_INCLUSAO")]
        public DateTime DataInclusao { get; set; }

        [Required(ErrorMessage ="Campo Obrigatorio"), MappingAtributo("DS_DESC"), StringLength(10, MinimumLength = 2)]
        public string Descricao { get; set; }
    }
}
