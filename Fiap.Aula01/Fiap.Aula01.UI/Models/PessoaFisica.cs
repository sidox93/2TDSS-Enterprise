using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Models
{
    class PessoaFisica : Pessoa, IEstudante
    {
        //Construtor
        public PessoaFisica(string nome) : base(nome)
        {

        }

        //Propriedades (Gets/Sets)
        public Etnia Etnia { get; set; }

        public string Cpf { get; set; }

        //prop -> tab tab
        public DateTime DataNascimento { get; set; }

        public void Estudar()
        {
            Console.WriteLine("Pessoa estudando!");
        }

        //Métodos
        public override void Vender()
        {
            Console.WriteLine("Pessoa fisica vendendo");
        }
    }
}
