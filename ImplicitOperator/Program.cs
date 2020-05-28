using System;

namespace ImplicitOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var clienteListViewModel = new ClienteListViewModel
            {
                DataNascimento = new DateTime(1982, 6, 12),
                Id = 5,
                Nome = "Jose",
                Sobrenome = "Carlos"
            };


            var cliente = RetornarCliente(clienteListViewModel);

            Console.WriteLine(cliente);


        }


        private static Cliente RetornarCliente(ClienteListViewModel cliente)
        {
            return cliente;
        }
    }
}
