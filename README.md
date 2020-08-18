# Seplag SonarQube

## Desenvolvimento de uma POC do SonarQube para Seplag

<!-- 027a3ae7d8fc2747608ffe85c4bac2e3fb6fa34f -->

#### O que é SonarQube?

* SonarQube é uma plataforma de código aberto para realizar revisões automáticas com análise estática de código para detectar bugs, possíveis problemas e vulnerabilidades de segurança. O SonarQube permite análisar mais de 25 linguagens de programação.

#### Que tipo de valor o SonarQube traz?

* Ajuda a detectar muitos problemas no código, graças à sua filosofia de focar no novo código, ajuda a corrigir os problemas assim que eles aparecem.

* Manter o código limpo, simples e fácil de ler também é muito mais fácil com SonarQube, pois muitas regras também se concentram naqueles aspectos que começam a render muito depois de algum tempo.

### Step

#### Pré-requisitos
* DotNet Core - https://dotnet.microsoft.com
* Docker - https://www.docker.com/get-started
* Git - https://git-scm.com/downloads

### Ininiando a aplicação:
* Acessar o [Play With Docker](https://labs.play-with-docker.com)
* Iniciar uma sessão no PWD.
* Comandos.
    * Realizar o clone do projeto: 
        * git clone https://gitlab.com/WandersonAFreitas/seplag-sonarqube  
    * Permitir baixar e executar os contêineres. O arquivo dockerfile criará dois contêiner, uma para SonarQube e outra para banco de dados Postgres:
        * docker-compose up -d 
    * Verificar se os contêineres estão em execução:
        * docker ps
    * Acessar o link disponibilizado pelo PWD.
    * Realizar o login do SonarQube.
        * Usuário: admin Senha: admin
    * Gerar um token para o projeto.
        * SeplagSonarQube
    * Selecione a linguagem C#




#### Links: 
    * https://medium.com/@cristianvitortrucco/utilizando-o-sonarqube-e-10-minutos-aa9de5749fb3
    * https://blog.setapp.pl/sonarqube_introduction