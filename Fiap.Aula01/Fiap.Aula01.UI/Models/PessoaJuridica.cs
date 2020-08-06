using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Models
{
    class PessoaJuridica : Pessoa
    {
        //Construtor
        //ctor -> tab tab
        public PessoaJuridica(string nome, string cnpj) : base(nome)
        {
            this.Cnpj = cnpj;
        }

        //Propriedades (Gets/Sets)
        public string Cnpj { get; set; }
        public string Contato { get; set; }

        //Métodos
        public override void Vender()
        {
            Console.WriteLine("Pessoa juridica vendendo");
        }

        //Sobrecrever o método Comprar de Pessoa
        public override void Comprar()
        {
            Console.WriteLine("Pessoa juridica comprando");
        }

    }
}
