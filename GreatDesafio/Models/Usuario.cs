using System;
using System.Collections.Generic;

namespace GreatDesafio.Models
{
    public partial class Usuario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Id { get; set; }
    }
}
