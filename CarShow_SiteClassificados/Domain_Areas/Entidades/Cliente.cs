using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain_Areas.Entidades
{
    //Essa entidade pode ser modificada de acordo com a precisão de atributos 
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public String Nome { get; set; }
        public int TipoCLiente { get; set; }

        public virtual ICollection<Contato> Contatos { get; set; }
        //public virtual Endereco Enderecos { get; set; } teoricamente não preciso saber o endereço da pessoa 
        public virtual Loguin Loguin { get; set; }
        public virtual ICollection<Automovel> Automoveis { get; set; }
 
    }
}
