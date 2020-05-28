using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitOperator
{
    public class ClienteListViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
            => $"{Id} - {Nome} - {Sobrenome} - {DataNascimento}";
    }
}
