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

Essa camada é responsável por expor APIs REST para consumo. Os métodos devem obedecer a premissão de "Thin Controllers", ou seja, nenhum regra de negócio
deve ser implementada aqui visando baixo acoplamento. Tudo é feito através de injeção de dependência.

### Tests

Essa camada contém testes, sendo eles testes unitários (para comandos, Core e handlers) e Fakes.

### Docker

Essa solução está dockerizada. Dentro da pasta "src" existe um Dockerfile com as instruções para geração de uma imagem.

Para criar, siga os passos a seguir:

- Se estiver no Windows, instale o Docker for Windows
- Vá até a pasta "src" do projeto, encontre o arquivo "Dockerfile"
- Abra um promp de comando e digite *docker build -t "api-iti:v1.0" .
- Após a criação da imagem, execute o comando "docker run <ID_IMAGEM>"
- Para visualizar se a imagem está rodando, digite o comando "docker ps"
- Para parar a execução do container, digite o comando "docker stop <ID_CONTAINER>"
