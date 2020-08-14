using Fiap.Banco.Model;
using Fiap.Exercicio01.UI.Exceptions;
using Fiap.Exercicio01.UI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    //alt + enter -> possíveis soluções para o problema
    //sealed -> a classe não pode ser herdada
    sealed class ContaCorrente : Conta
    {
        //Propriedade
        public TipoConta Tipo { get; set; }

        //Métodos
        public override void Retirar(decimal valor)
        {
            if (valor > Saldo && Tipo == TipoConta.Comum)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente");
            }
            Saldo -= valor; //Saldo = Saldo - valor;
        }
    }
}
