using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(int id, string nome, int idade, string cpf)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int  Idade { get; set; }
        public string Cpf { get; set; }
    }
}
