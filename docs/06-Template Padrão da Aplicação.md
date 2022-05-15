# Template Padrão da Aplicação

O template padrão a ser utilizado corresponde aos modelos de wireframes interativos propostos, disponíveis no tópico "Projeto de Interface", com responsividade de acordo com o padrão bootstrap. É composto de:
1. Tela principal (home);
2. Tela de cadastro;
3. Tela de login.

## Tela principal

A tela principal possui uma barra de navegação disposta no cabeçalho, contendo o título do site, e rotas para: a própria home, o estacionamento, o cadastro de cliente e o login de cliente.
O conteúdo da tela principal possui um campo de busca, sinalizado com um ícone de localização, para que o potencial cliente de um estacionamento informe o seu endereço e faça uma busca. Para isso, basta digitar a informação no campo em branco e clicar no botão sinalizado com uma lupa. O resultado da busca serão as opções de estacionamentos próximos ao local informado, que possuam vagas disponíveis para o cliente estacionar seu veículo.
Por fim, há um rodapé com informações adicionais sobre a aplicação.
Tanto o cabeçalho quanto o rodapé serão visualizados em todas as telas da aplicação, sendo este o layout padrão da aplicação, uma vez que será utilizado em todas as páginas. 

![telaHome](https://user-images.githubusercontent.com/88891675/168498077-42343e77-1d53-4189-9565-56a8b9c683ba.jpg)

<br>

## Tela de cadastro

A tela de cadastro foi construída com base no modelo de cards e formulários disponível no Bootstrap. Essa tela possui sua versão tanto para o estacionamento quanto para o cliente. 
Para fazer o cadastro de um estacionamento, basta clicar no botão "Estacionamento", disposto no canto superior direito da barra de navegação, e na tela que será exibida em seguida, clicar na opção "Cadastre seu estacionamento!". 
Para o cliente se cadastrar, basta clicar no botão "Criar conta", também disposto no canto superior direito da barra de navegação.  
Ambas as opções possuem um formulário de cadastro, disposto no lado direito da tela. Todos os camposdo formulário deverão ser preenchidos. O botão "Cadastrar", ao final do formulário, efetiva o cadastro das informações no sistema. E o botão "Voltar" redireciona quaisquer dos usuários para a tela principal. 

![telaCadastroEstacionamento](https://user-images.githubusercontent.com/88891675/168498095-d00c18f8-f5c8-45f8-ae1a-dfea7907c243.jpg)
(Tela de Cadastro do Estacionamento)
<br>
<br>
<br>
![telaCadastroUsuario](https://user-images.githubusercontent.com/88891675/168498111-3940c822-276f-4f5e-84c6-8f1006b140db.jpg)
(Tela de Cadastro do Cliente)
<br>
## Tela de login

A tela de login pode ser acessada ao clicar no botão "Login", também disposto no canto superior direito da barra de navegação, ao lado do botão "Criar conta". Assim com a tela de cadastro, a tela de login possui duas versões, uma para o cliente e outra para o estacionamento. A tela segue o mesmo padrão de layout da tela de cadastro, com campos a serem preenchidos pelo usuário cadastrado dispostos no lado direito da tela. O botão "Entrar", ao final dos campos, redireciona para o ambiente de interação do cliente ou do estacionamento. E o botão "Voltar" redireciona quaisquer dos usuários para a tela principal.
![telaLogin](https://user-images.githubusercontent.com/88891675/168498186-c939ed06-c144-4f72-b498-5f666949f3aa.jpg)



