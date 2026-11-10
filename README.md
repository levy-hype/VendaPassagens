# Venda de Passagens

Aplicação desktop de estudo para consultar e cadastrar informações de passagens aéreas. O projeto demonstra uma interface Windows Forms conectada a um banco MySQL; não é uma plataforma de vendas online e não processa pagamentos.

## Funcionalidades

- Tela de entrada para acessar a aplicação.
- Consulta e listagem de passagens armazenadas no MySQL.
- Cadastro e edição de registros por formulários.
- Exibição de origem, destino, data e hora do voo, companhia aérea e preço.

## Tecnologias

- C# e Windows Forms
- .NET 9 (net9.0-windows)
- MySQL e MySql.Data 9.4.0

## Requisitos

- Windows
- .NET 9 SDK
- Instância MySQL acessível
- Banco de dados com a tabela passagens descrita abaixo

## Banco de dados

A consulta da aplicação espera uma tabela chamada passagens com os campos abaixo. Ajuste tipos e tamanhos conforme necessário para o ambiente local:

~~~sql
CREATE TABLE passagens (
    Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Origem VARCHAR(150) NOT NULL,
    Destino VARCHAR(150) NOT NULL,
    DataHoraVoo DATETIME NOT NULL,
    CompanhiaAerea VARCHAR(150) NOT NULL,
    Preco DECIMAL(10, 2) NOT NULL
);
~~~

Configure a conexão MySQL usada por Conexao.stringConexao antes de executar. Não publique senhas ou credenciais reais no repositório.

## Executar no Windows

Na raiz do repositório, restaure as dependências e inicie o projeto:

~~~powershell
dotnet restore .\VendaPassagens.sln
dotnet run --project .\VendaPassagens\VendaPassagens.csproj
~~~

## Observações

- Este projeto é uma aplicação de estudo; não implementa compra ou processamento de pagamentos.
- A tela de entrada e as credenciais de demonstração presentes no código não constituem autenticação adequada para uso real. Revise-as antes de qualquer distribuição.
- A conexão e o banco são locais: nenhum serviço hospedado é fornecido por este repositório.

## Estrutura

~~~text
VendaPassagens.sln
VendaPassagens/
├── Form1.cs                 # Tela de entrada
├── Form2.cs                 # Consulta e listagem
├── Form3.cs                 # Cadastro e edição
└── VendaPassagens.csproj
~~~
