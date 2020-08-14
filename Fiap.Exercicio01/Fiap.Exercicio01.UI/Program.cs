using Fiap.Banco.Model;
using Fiap.Exercicio01.UI.Exceptions;
using System;

namespace Fiap.Exercicio01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma ContaCorrente e uma ContaPoupança
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 213,
                Saldo = 100,
                Tipo = Models.TipoConta.Comum,
                DataAbertura = new DateTime(2020, 1, 1)
            };

            var cp = new ContaPoupanca(0.003m)
            {
                Agencia = 1,
                Numero = 349,
                Saldo = 200,
                DataAbertura = DateTime.Now,
                Taxa = 1
            };

            try
            {
                cc.Retirar(1000);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message); //cw tab tab
            }

        }
    }
}
