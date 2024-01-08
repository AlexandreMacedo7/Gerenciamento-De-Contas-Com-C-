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
        public decimal Saldo {get; private set;}

        public Conta(){}

        public Conta(int codigo, int numerodaConta, string titular, decimal saldo){
            Codigo = codigo;
            NumeroDaConta = numerodaConta;
            Titular = titular;
            Saldo = saldo;
        }

        public decimal ConsultarExtrato(){
            return Saldo;
        }
        public decimal RealizarDeposito(decimal deposito){
            return Saldo = Saldo + (deposito - 1);
        }
        public void RealizarSaque(decimal saque){
            if(saque < Saldo){
                Saldo = Saldo - (saque + 1);
            }
            else{
                Console.WriteLine($"Saldo insuficiente para saque no valor de: R$ {saque}");
            }
            
        }
    }
}