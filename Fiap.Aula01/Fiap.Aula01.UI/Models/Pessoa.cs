using Fiap.Aula01.UI.Exceptions;
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

        //Sobrecarga de método
        public void Comprar(int valor)
        {
            //Validar se o valor é positivo, caso contrário lançar exception
            if (valor < 0)
            {
                throw new ValorInvalidoException("Valor não pode ser negativo");
            }
            Console.WriteLine("Pessoa comprando com " + valor);
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
