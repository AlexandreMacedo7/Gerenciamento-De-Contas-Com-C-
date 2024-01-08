# Projeto de Contas Bancárias em C#

Este projeto é um exemplo simples de um sistema bancário em C# no console. Ele inclui classes para representar contas, contas de pessoa física, contas de pessoa jurídica, e métodos básicos de saque, depósito e consulta de saldo.

## Funcionalidades

- Contas bancárias para pessoa física e jurídica.
- Métodos de saque, depósito e consulta de saldo.
- Cada conta possui um código, titular, CPF ou CNPJ e saldo.

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado.

Estrutura do Projeto

    Conta.cs: Classe base para representar uma conta bancária.
    PessoaFisica.cs: Classe para representar contas de pessoa física, herdando de Conta.
    PessoaJuridica.cs: Classe para representar contas de pessoa jurídica, também herdando de Conta.
    Program.cs: Ponto de entrada do programa, contendo a lógica principal.
