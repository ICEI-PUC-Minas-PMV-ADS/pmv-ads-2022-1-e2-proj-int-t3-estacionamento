# Programação de Funcionalidades

## Instruções de acesso:
1. Abra um navegador de Internet e informe a seguinte URL:https://whypark.azurewebsites.net
Ou para executar localmente:
2. Copie o repositório através desse link: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t3-estacionamento.git
3. Com o .Net framework instalado em sua máquina, execute dentro da pasta webWHypark o comando "dotnet watch".

## Funcionalidade implementadas 

Nesta etapa, foram entregues as seguintes funcionalides:

**Cadastro de Clientes** (/CadastroCliente/Create)
RF-02 O sistema deve permitir que o cliente crie uma conta para realizar um cadastro simples, com exigência de nome e email, que permitirá realizar a busca e a reserva da vaga.

Artefatos utilizados:
- CadastroClienteController.cs
- Create.cshtml
- cadastroCliente.svg

**Login de Clientes** (/LoginCliente/Login)
RF-02 O sistema deve permitir que o cliente crie uma conta para realizar um cadastro simples, com exigência de nome e email, que permitirá realizar a busca e a reserva da vaga.

Artefatos utilizados:
- LoginClientesController.cs
- AcessDenied.cshtml
- Login.cshtlm
- carro.svg

**Cadastro de Estacionamento** (/Estacionamento/Create)
RF-06 O sistema deve permitir que a empresa crie uma conta para realizar a gestão do estacionamento, inserindo razão social, CNPJ, endereço, telefone e email.

Artefatos utilizados:
- EstacionamentoController.cs
- Index.cshtml
- Create.cshtml
- Tabela.cshtml
- parking-animate.svg
- estacionamento.svg
- entrarEstacionamento.svg

## Deploy e Hospedagem

A aplicação e o banco de dados utilizam o serviço de hospedagem Microsoft Azure. O deploy da aplicação foi realizado por meio de submssisão do código-fonte via associação do repositório remoto(Git Hub) e concesessão de autorizações para o servidor Azure.
Utilizando a assinatura de estudante, foi possível criar um servidor windows para hospedar a aplicação e manter online o banco de dados utilizando o SQL server como sistema gerenciador.
A aplicação encontra-se online no ambiente da URL:https://whypark.azurewebsites.net
