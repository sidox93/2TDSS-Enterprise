using Fiap.Exercicio01.UI.Exceptions;
using Fiap.Exercicio01.UI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Propriedade -> prop tab tab
        public decimal Taxa { get; set; }

        //Field
        // readonly -> é possível atribuir valor somente na declaração ou no constror
        private readonly decimal _rendimento;

        //Construtor ->  ctor tab tab
        public ContaPoupanca(decimal rendimento)
        {
            this._rendimento = rendimento;
        }

        //Métodos
        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor + Taxa)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente");
            }
            Saldo -= valor + Taxa;
        }
    }
}
