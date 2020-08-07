using Fiap.Aula01.UI.Exceptions;
using Fiap.Aula01.UI.Models;
using System;
using System.Collections;
using System.Collections.Generic;

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

            pf.Etnia = Etnia.Mulato;

            //Exibir o nome
            Console.WriteLine(pf.Nome);

            //Criar uma lista de pessoa jurídica
            IList<PessoaJuridica> lista = new List<PessoaJuridica>();

            //Adicionar 2 pf na lista
            lista.Add(new PessoaJuridica("FIAP", "123.123.123/0001-98"));

            var pj = new PessoaJuridica("Coca-Cola", "524.234.234/0001-23");
            lista.Add(pj);

            //Exibir todos os dados da lista
            foreach (var item in lista)
            {
                Console.WriteLine(item.Nome + " " + item.Cnpj);
            }

            //Chamar o método e tratar a exception
            try
            {
                pf.Comprar(-10);
            }
            catch (ValorInvalidoException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
