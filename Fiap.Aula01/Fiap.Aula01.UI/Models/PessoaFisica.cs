using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Models
{
    class PessoaFisica : Pessoa
    {
        //Construtor
        public PessoaFisica(string nome) : base(nome)
        {

        }

        //Propriedades (Gets/Sets)
        public string Cpf { get; set; }

        //prop -> tab tab
        public DateTime DataNascimento { get; set; }

        //Métodos
        public override void Vender()
        {
            Console.WriteLine("Pessoa fisica vendendo");
        }
    }
}
