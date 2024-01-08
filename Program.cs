// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GerenciamentoDeContasComC_;


List<Conta> Contas = new List<Conta>();



VerificacaoDeEntrada();

void VerificacaoDeEntrada(){

    Console.WriteLine("Bem vindo ao Banco C#\n");
    Console.WriteLine(
        "Novo cliente :-D - Digite 1\n"
        +"Já é cliente :-) - Digite 2\n"
        +"Sair do sistema :-/ Digite 0");

    string input = Console.ReadLine();

    switch(input){
        
        case "1":
        CriarConta();
        VerificacaoDeEntrada();
        break;
        
        case "2":
        ConsultarCliente();
        VerificacaoDeEntrada();
        break;
        
        case "0":
        Console.WriteLine("Volte logo! :-)");
        break;

        default:
        Console.WriteLine("Opção inválida");
        VerificacaoDeEntrada();
        break;
    }
}
void CriarConta(){
    
    Console.WriteLine("Seja bem vindo! Vamos criar sua conta!");
    Console.WriteLine("Qual o tipo de conta?");
    Console.WriteLine("Pessoa Fisica: Digite - 1\nPessoa Juridica: Digite - 2");
    string tipo = Console.ReadLine();
    
    switch(tipo){
        case "1":
        CriarContaPessoaFisica();
        break;
        case "2":
        CriarContaPessoaJuridica();
        break;
        default:
        Console.WriteLine("Opção invalida!");
        break;
    }
}
void CriarContaPessoaFisica(){
    
    Console.WriteLine("CPF");
    string cpf = Console.ReadLine();

    Conta dados = CriarDadosDaConta();

    PessoaFisica pessoaFisica = new PessoaFisica(dados.Codigo, dados.NumeroDaConta, 
    dados.Titular, cpf, dados.Saldo);
    
    Contas.Add(pessoaFisica);

    Console.WriteLine($"Seja bem vindo! {pessoaFisica.Titular} - Seu código de acesso é:" 
    + $"{pessoaFisica.Codigo} - Faça seu login novamente!");
}
void CriarContaPessoaJuridica(){

    
    Console.WriteLine("CNPJ");
    string cnpj = Console.ReadLine();

    Conta dados = CriarDadosDaConta();

    PessoaJuridica pessoaJuridica = new PessoaJuridica(dados.Codigo, dados.NumeroDaConta, 
    dados.Titular, cnpj, dados.Saldo);
    
    Contas.Add(pessoaJuridica);

    Console.WriteLine($"Seja bem vindo! {pessoaJuridica.Titular} - Seu código de acesso é:" 
    + $"{pessoaJuridica.Codigo} - Faça seu login novamente!");

}
Conta CriarDadosDaConta(){

    Console.WriteLine("Código: ");
    string codigoString = Console.ReadLine();
    int codigo = int.Parse(codigoString);

    Console.WriteLine("Conta: ");
    string contaString = Console.ReadLine();
    int conta = int.Parse(contaString);

    Console.WriteLine("Titular: ");
    string titular = Console.ReadLine();

    Console.WriteLine("Saldo");
    string saldoString = Console.ReadLine();
    decimal saldo = int.Parse(saldoString);

    Conta contaGerada = new Conta(codigo,conta,titular,saldo);
    return contaGerada;
}

void ConsultarCliente(){

    Console.WriteLine("Digite seu código: ");
    String input = Console.ReadLine();
    int codigo = int.Parse(input);

    Conta contaEncontrada = Contas.FirstOrDefault(conta => conta.Codigo == codigo);

        if(contaEncontrada != null){
            ExibirMenu(contaEncontrada);
        }else{
            Console.WriteLine("Conta não encontrada!");
        }
}

void ExibirMenu(Conta conta){
    
    Console.WriteLine("Menu");
    Console.WriteLine("1 - Saldo");
    Console.WriteLine("2 - Deposito");
    Console.WriteLine("3 - Saque");
    Console.WriteLine("0 - Sair");
    string input = Console.ReadLine();

    switch(input){
        
        case "1":
        Extrato(conta);
        break;
        
        case "2":
        Deposito(conta);
        break;

        case "3":
        Saque(conta);
        break;
        
        case "0":
        Console.WriteLine("Volte logo! :-)");
        break;

        default:
        Console.WriteLine("Opção inválida");
        VerificacaoDeEntrada();
        break;
    }
}
void Extrato(Conta conta){
    Console.WriteLine($"Olá {conta.Titular}");
    Console.WriteLine($"Número da conta {conta.NumeroDaConta}");
    Console.WriteLine($"Seu saldo é: R$ {conta.Saldo}");
}
void Deposito(Conta conta){
    Console.WriteLine("Digite o valor para deposito");
    string input = Console.ReadLine();
    decimal deposito = int.Parse(input);
    conta.RealizarDeposito(deposito);
    Console.WriteLine($"Taxa de movimentação R$ 1,00");
    Console.WriteLine($"Deposito bem sucedido! Saldo atual: R${conta.Saldo}");
}

void Saque(Conta conta){
    Console.WriteLine("Digite o valor para saque");
    string input = Console.ReadLine();
    decimal saque = int.Parse(input);
    conta.RealizarSaque(saque);
    Console.WriteLine($"Taxa de movimentação R$ 1,00");
    Console.WriteLine($"Saldo atual: R${conta.Saldo}");
}