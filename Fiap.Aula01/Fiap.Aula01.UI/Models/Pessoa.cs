using System;
using System.Collections.Generic;
using System.Text;


namespace Fiap.Aula01.UI.Models
{
    //Classe abstrata -> não pode ser instanciada
    //e pode conter métodos abstratados (sem implementação)
    abstract class Pessoa
    {
        //Métodos
        //virtual -> permite a sobrescrita do método
        public virtual void Comprar()
        {
            Console.WriteLine("Pessoa comprando");
        }

        public abstract void Vender();

        //Construtores
        public Pessoa(string nome)
        {
            _nome = nome;
        }

        //Fields (Atributos)
        private string _nome;

        private string _telefone;

        //Properties (Gets/Sets)
        public string Endereco { get; set; }

        public string Nome
        {
            get { return _nome; }
            set {  _nome = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

    }
}
