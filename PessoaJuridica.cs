using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeContasComC_
{
    public class PessoaJuridica : Conta
    {
        public string Cnpj {get; private set;}


        public PessoaJuridica(int codigo, int numerodaConta, string titular, string cnpj, decimal saldo)
        :base(codigo, numerodaConta, titular, saldo){
            Cnpj = cnpj;
        }
        
    }
}