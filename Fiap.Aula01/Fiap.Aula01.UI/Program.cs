using Fiap.Aula01.UI.Models;
using System;

namespace Fiap.Aula01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intanciar uma pessoa física
            PessoaFisica pf = new PessoaFisica("Maria")
            {
                Cpf = "123123123123",
                DataNascimento = DateTime.Now
            };

            //Atribuir um valor para o nome
            pf.Nome = "Joao";

            //Exibir o nome
            Console.WriteLine(pf.Nome);

        }

    }
}
