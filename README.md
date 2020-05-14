# App demo para o projeto Iti

Esse repositório é uma implementação demo.

## Ferramentas, Tecnologias, Conceitos e práticas utilizadas
* Visual Studio 2019
* Docker for Windows
* .NET Core 2.2
* C#
* Test Driven Development
* Conceitos de DDD (Contextos delimitados)
* Handlers (Adaptadores) e Inputs/Outputs (Portas) para comunicação entre camadas
* Responsabilidade única, Abstrações, Encapsulamento

## Sobre as camadas e suas responsabilidades

### Aplicação (Application)

Essa camada é responsável por toda lógica da aplicação. Ela depende da camada de domínio e da camada Core, onde temos funcionalidades compartilhadas.
As lógicas são implementadas através de Handlers, onde abstraimos intenções de regras de negócio e separamos as lógicas por contextos delimitados.

### Domínio (Domain)

Essa camada é responsável por todas as entidades, enumerações, exceções, abstrações e lógicas específicas ao domínio de negócio.

### Infraestrutura (Infrastructure)

Essa camada é responsável por conter classes que acessem recursos externos a nossa aplicação, como por exemplo web services, emails ou até mesmo acesso a disco. Essas classes devem implementar abstrações da camada de domínio.
Como não estamos acessando nenhum recurso externo, nenhum implementação foi feita.

### APIs

Essa camada é responsável por expor APIs REST para consumo. Os métodos devem obedecer a premissa de "Thin Controllers", ou seja, nenhum regra de negócio deve ser implementada aqui visando baixo acoplamento. Tudo é feito através de injeção de dependência. Por se tratar de uma demo, não me atentei ao fato de utilizar HTTP status code adequadamente, estou sempre retornando um JSON com o status da requisição, uma mensagem e conteúdo do request. O ideal seria retornar os https status codes adequadamente.

### Tests

Essa camada contém testes, sendo eles testes unitários (para comandos, Core e handlers) e Fakes. Não temos acesso a banco de dados ou alguma outra fonte externa, dessa forma os testes de integração não foram construídos. Se houvesse a necessidade de conexão com banco de dados, seria possível criar um Mock ou um acesso a dados em banco In-Memory (utilizando Entity Framework por exemplo) para testar a integração com fontes externas a API.

### Docker

Essa solução está dockerizada. Dentro da pasta "src" existe um Dockerfile com as instruções para geração de uma imagem.

Para criar, siga os passos a seguir:

- Se estiver no Windows, instale o Docker for Windows
- Vá até a pasta "src" do projeto, encontre o arquivo "Dockerfile"
- Abra um promp de comando e digite *docker build -t "api-iti:v1.0" .
- Após a criação da imagem, execute o comando "docker run <ID_IMAGEM>"
- Para visualizar se a imagem está rodando, digite o comando "docker ps"
- Para parar a execução do container, digite o comando "docker stop <ID_CONTAINER>"
