using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeContasComC_
{
    public class Conta
    {
        public int Codigo{get; private set;}
        public int NumeroDaConta {get; private set;}
        public string Titular {get; private set;}
        public decimal saldo {get; private set;}

        public Conta(){}

        public Conta(int codigo, int numerodaConta, string titular, decimal saldo){
            Codigo = codigo;
            NumeroDaConta = numerodaConta;
            Titular = titular;
            saldo = saldo;
        }

        public decimal ConsultarExtrato(){
            return saldo;
        }
        public decimal RealizarDeposito(decimal deposito){
            return saldo =+ deposito;
        }
        public decimal RealizarSaque(decimal saque){
            if(saque >= saldo){
                Console.WriteLine($"Saldo insuficiente para saque no valor de: R$ {saque}");
            }
            return saldo - saque;
        }
    }
}