using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitOperator
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Renda { get; set; }

        public override string ToString()
            => $"{Id} - {Nome} - {Sobrenome} - {DataNascimento} - {Renda}";


        public static implicit operator Cliente(ClienteListViewModel professionResponse)
        {
            return new Cliente
            {
                Id = professionResponse.Id,
                DataNascimento = professionResponse.DataNascimento,
                Sobrenome = professionResponse.Sobrenome,
                Nome = professionResponse.Nome,
            };
        }
    }
}
