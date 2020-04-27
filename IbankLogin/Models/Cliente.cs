using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IbankLogin.Models
{
   [Table("Clientes")]
   public class Cliente
   {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public int Senha { get; set; }
        }
}
