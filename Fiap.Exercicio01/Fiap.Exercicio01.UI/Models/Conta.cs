using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    abstract class Conta
    {
        //Propriedades -> prop tab tab
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        //Métodos
        public virtual void Depositar(decimal valor)
        {
            Saldo += valor; //Saldo = Saldo + valor;
        }

        public abstract void Retirar(decimal valor);

    }
}
