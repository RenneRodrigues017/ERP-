using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ERP.Commun.Models
{
    public class Cliente(string nomeParametro)
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        private string _nome = nomeParametro;
        public string Nome
        {
            get=> _nome;
            set
            {
               if (string.IsNullOrWhiteSpace(value)) 
            {
                throw new ArgumentNullException(nameof(Nome), "O nome do cliente não pode ser nulo ou vazio.");
            }
                _nome = value;
            }
        }
        public bool Status { get; set; } = true;
    }
}