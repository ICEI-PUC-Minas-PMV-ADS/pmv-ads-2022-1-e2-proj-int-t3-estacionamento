# Especificações do Projeto

<p>A definição do problema foi consolidada tendo como base as experiências pessoais dos membros do grupo, assim como de pessoas próximas a cada um, que compartilham a mesma necessidade. Com base nisso, foi possível inferir outros possíveis problemas enfrentados por clientes, gerentes e manobristas. Tais detalhes foram organizados em personas e histórias de usuários.</p>

## Personas

<p>As personas levantadas durante o processo de compreensão do problema são apresentadas nas figuras que se seguem:</p>

|<img src="https://user-images.githubusercontent.com/88891675/157912851-11f79a89-7db9-4e4a-9327-b422d2cb8745.jpg" width="200">| Cesefredo José |
|-------------------------------------------------------------------|------------------------------------------------------------|
| Idade | 60 anos |
| Ocupação | Proprietário e gestor de empresas de estacionamento. |
| Aplicativos | Facebook, WhatsApp, aplicativos bancários. |
| Motivação | Inserir sua empresa no mundo digital. |
| Frustração | Dificuldade em acompanhar os avanços tecnológicos. |

<br>

|<img src="https://user-images.githubusercontent.com/88891675/157914286-22aa9f05-f9a7-4785-a7ce-7f8730c8d551.jpg" width="285">| Marco Marcelo Tolentino |
|-------------------------------------------------------------------|------------------------------------------------------------|
| Idade | 38 anos |
| Ocupação | Manobrista (profissional habilitado para movimentar e posicionar veículos em um estacionamento). |
| Aplicativos | Facebook, WhatsApp, Netflix, aplicativos bancários. |
| Motivação | Obter informações constantemente atualizadas para organizar o posicionamento dos veículos de forma mais prática e funcional possível. |
| Frustração | Falta de praticidade do sistema de estacionamento, atualmente feita com uma aplicação muito simples e obsoleta. |
      
<br>

|<img src="https://user-images.githubusercontent.com/88891675/157915662-4881cd55-ef7e-467f-bbfc-0aea1ccb9c56.jpg" width="380"> | Clotilde Maria |
|-------------------------------------------------------------------|------------------------------------------------------------|
| Idade | 32 anos |
| Ocupação | Representante comercial. |
| Aplicativos | Facebook, WhatsApp, Linkedin, Instagram, Waze, aplicativos bancários. |
| Motivação | Agilidade em seus deslocamentos para visita a clientes. |
| Frustração | Impossibilidade de fazer reserva de vaga com antecedência em estacionamentos próximos aos locais de suas visitas, perdendo tempo na busca por uma vaga para estacionar o seu veículo. |

<br>

|<img src="https://user-images.githubusercontent.com/88891675/157916479-9fad2223-9db8-445e-8d2c-14fe156fcf9b.jpg" width="485">| Lourival Filho |
|-------------------------------------------------------------------|------------------------------------------------------------|
| Idade | 28 anos |
| Ocupação | Jovem empreendedor. |
| Aplicativos | Facebook, WhatsApp, Linkedin, Instagram, Waze, aplicativos bancários. |
| Motivação | Estacionar o seu veículo em uma vaga reservada, em um estacionamento próximo à sua empresa. |
| Frustração | Como necessita realizar atividades fora da empresa com frequencia, utiliza o carro em diversos momentos do dia. Nem sempre encontra vaga em estacionamentos próximos ao seu local de trabalho e precisa ficar sempre trocando de estacionamento. |

<br>

## Histórias de Usuários

<p>Com base na análise das personas forma identificadas as seguintes histórias de usuários:</p>

<br>

|EU COMO... `PERSONA`   | QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|-----------------------|------------------------------------|----------------------------------------|
|Cesefredo José         | Modernizar a gestão do estacionamento. | Adequar-se às novas tecnologias disponíveis para gestão do negócio. |
|Cesefredo José         | Implementar um sistema que proporcione o controle de fluxo.| Organizar de forma ágil e segura as informações de entrada e saída dos veículos. |
|Cesefredo José         | Ampliar a visibilidade da empresa no mercado. | Expandir a rede de estacionamentos. |
|Marco Marcelo Tolentino| Acessar de forma rápida informações sobre a quantidade de vagas disponíveis no estacionamento. | Atender com maior qualidade ao cliente que chega ao estacionamento.  |
|Marco Marcelo Tolentino| Ter acesso às informações sobre a quantidade de horas contratadas por cada veículo estacionado. | Organizar melhor a disposição dos veículos no ambiente do estacionamento. |
|Marco Marcelo Tolentino| Orientar o cliente, no momento do checkout para que faça o pagamento online. | Facilitar o processo de cobranças e recebimentos do caixa. |
|Clotilde Maria         | Utilizar aplicativo de busca de vagas de estacionamento de acordo com sua localização. | Ter comodidade, conforto e segurança, sem se preocupar com a busca de local para estacionar. |
|Clotilde Maria         | Localizar rapidamente uma vaga de estacionamento. | Contar com a praticidade de estacionar facilmente nos grandes centros urbanos. |
|Clotilde Maria         | Ter facilidade para fazer pagamento online. | Não se preocupar em portar dinheiro para pagamento dos serviços de estacionamento. |
|Lourival Filho         | Localizar estacionamentos próximos a sua empresa, com melhor custo-benefício. | Estacionar seu carro novo com segurança, sem se preocupar com possíveis furtos ou danos ao veículo. |
|Lourival Filho         | Reservar vaga em um estacionamento. | Precisar sair da sua empresa, em eventuais momentos, e ter sua vaga disponível no seu retorno. |

## Casos de uso

<p> De acordo com o perfil e as histórias das personas mencionadas no item anterior, foram identificados os seguintes casos de uso:</p>

<p>Para o gestor do estacionamento:<br>
•	Cadastrar a empresa no sistema;<br>
•	Cadastrar o número de vagas existentes no estacionamento;<br>
•	Cadastrar o número de vagas reservadas para mensalistas e diaristas;<br>
•	Cadastrar o valor das vagas, por hora, dia ou mês;<br>
•	Cadastrar as formas de pagamento que poderão ser aceitas.<br></p>
<br>
<p>Para o manobrista da empresa:<br>
•	Visualizar o status das vagas (disponíveis e ocupadas);<br>
•	Lançar no sistema as vagas ocupadas por clientes sem acesso ao aplicativo;<br>
•	Visualizar o tempo de ocupação das vagas;<br>
•	Calcular o valor do serviço para cada cliente.<br></p>
<br>
<p>Para o cliente usuário do estacionamento:<br>
•	Informar o endereço em que estiver no momento da busca;<br>
•	Realizar cadastro fornecendo nome e email;<br>
•	Efetuar busca por estacionamentos próximos ao endereço informado;<br>
•	Selecionar o estacionamento escolhido para indicar o interesse por uma vaga;<br>
•	Realizar o pagamento do uso do estacionamento.<br></p>

## Ambiente a ser implementado

<p>O ambiente onde o sistema será implementado é um estacionamento de veículos para fins comerciais, sendo o estacionamento uma área de dimensões limitadas, previamente destinadas à locação de veículos por determinado período.</p>

## Requisitos

<p>Para alcançar satisfatoriamente a solução do problema apresentado, todas as suas características serão descritas por meio dos requisitos que serão apresentados para tal, com o objetivo de determinar as funcionalidades previstas para o projeto. </p>
<p>Assim, serão apresentados requisitos funcionais e requisitos não funcionais, sendo respectivamente, os que descrevem as funcionalidades que o sistema deverá apresentar para permitir a interação dos usuários, e aqueles que descrevem as qualidades que o sistema e suas funcionalidades devem apresentar para sua aceitação.</p>
<p>As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.</p>

### Requisitos Funcionais

|ID      | Descrição do Requisito  | Prioridade |
|--------|-----------------------------------------|----|
|RF-01| O sistema deve apresentar um mecanismo de busca que permita ao cliente localizar estacionamentos cadastrados que possuam vagas para estacionamento imediato de acordo com sua localização. | ALTA | 
|RF-02| O sistema deve permitir que o cliente crie uma conta para realizar um cadastro simples, com exigência de nome e email, que permitirá realizar a busca e a reserva da vaga.  | ALTA |
|RF-03| O sistema deve apresentar uma página com cada estabelecimento comercial destinado à disponibilização de vagas de estacionamento para que o cliente proceda com a melhor escolha.  | ALTA |
|RF-04| O sistema deve permitir ao usuário efetuar a reserva online da vaga no estabelecimento escolhido. | ALTA |
|RF-05| O sistema deve permitir que o cliente salve como favorito um determinado estabelecimento. | BAIXA |
|RF-06| O sistema deve permitir que o usuário crie uma conta para realizar um cadastro simples, com exigência de nome e email, para permitir o cadastro. | ALTA |
|RF-07| O sistema deve permitir que o gestor do estacionamento realize cobrança online. | ALTA |
|RF-08| O sistema deve permitir que o gestor do estacionamento visualize a quantidade de vagas disponíveis. | ALTA |
|RF-09| O sistema deve permitir que o gestor do estacionamento visualize a quantidade de vagas ocupadas. | ALTA |
|RF-10| O sistema deve permitir que o manobrista visualize a quantidade de horas contratadas por cada veículo estacionado. | BAIXA |
|RF-11| O sistema deve permitir comunicação entre o cliente e o estabelecimento. | BAIXA |
|RF-12| O sistema deve permitir que a empresa de estacionamento seja avaliada pelo cliente. | BAIXA |

### Requisitos não Funcionais

|ID      | Descrição do Requisito  |Prioridade |
|--------|-----------------------------------------|----|
|RNF-01|  O sistema será implementado por uma plataforma Web. | ALTA | 
|RNF-02| O sistema deve ser totalmente responsivo. | ALTA |
|RNF-03| O sistema deve conter tecnologias e versões adaptadas para ser renderizada nos navegadores mais usados (Google Chrome, Microsoft Edge, Firefox, Microsoft Explore). | ALTA | 
|RNF-04| O sistema deve ser publicado em um ambiente acessível publicamente na internet (Heroku). | ALTA | 
|RNF-05| O sistema deve consumir APIs externas para realização de funcionalidades de geolocalização (Via CEP). | ALTA | 
|RNF-06|  O sistema deverá usar banco de dados relacional (SQL). | ALTA | 

## Restrições

<p>As restrições listadas na tabela abaixo limitam a execução deste projeto:</p>

|ID| Restrição                                             |
|-----|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue ao final do semestre letivo, não podendo ultrapassar a data de 26/06/2022.|
|RE-02| O projeto deverá se restringir às tecnologias básicas de uma aplicação interativa.|
|RE-03| O projeto deverá ser desenvolvido por uma equipe composta por cinco membros.|
|RE-04| O banco de dados a ser utilizado deverá ser da categoria relacional.|

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
