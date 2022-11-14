# Desafio Carrefour

### Objetivo: 
 - Sistema microservices para controle do fluxo de caixa
 
### Tecnologias Utilizadas:
 - .NET Core 7
 - Docker
 - Postgres
 - Entity Framework Core (Code First)
 - Migrations
 - API Gateway
 
### Descrição do projeto
 - O projeto foi desenvolvido utilizando o padrão de microservices, na frente do projeto existe um gateway que direciona as chamadas http para o microserviço desejado, para isso foi utilizado o api gateway .net chamado ocelot.

### Como rodar o projeto
 -  Abra o projeto utilizando cmd/bash e entre na pasta raiz;
 -  Rode o docker compose utilizando o seguinte comando;
 
        docker compose -f docker-compose.yml up
 
 - Entre na pasta APIMSLancamentos e rode o seguinte comando para atualizar o database e gerar as tabelas no postgres;
  
        dotnet ef database update --connection "Host=localhost;Port=5432;Pooling=true;Database=postgres;User Id=admin;Password=admin;"
 
 - Projeto inicializado com sucesso.
 
