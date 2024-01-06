using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeContasComC_
{
    public class PessoaFisica : Conta
    {
        public string Cpf{get; private set;}

        public PessoaFisica(int codigo, int numerodaConta, string titular, string cpf, decimal saldo)
        :base(codigo, numerodaConta, titular, saldo){
            Cpf = cpf;
        }
    }
    
}