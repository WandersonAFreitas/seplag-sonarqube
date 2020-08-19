# Seplag SonarQube

## Desenvolvimento de uma POC do SonarQube para Seplag

<!-- 027a3ae7d8fc2747608ffe85c4bac2e3fb6fa34f -->

#### O que é SonarQube?

* SonarQube é uma plataforma de código aberto para realizar revisões automáticas com análise estática de código para detectar bugs, possíveis problemas e vulnerabilidades de segurança. O SonarQube permite análisar mais de 25 linguagens de programação.

#### Que tipo de valor o SonarQube traz?

* Ajuda a detectar muitos problemas no código, graças à sua filosofia de focar no novo código, ajuda a corrigir os problemas assim que eles aparecem.
* Manter o código limpo, simples e fácil de ler também é muito mais fácil com SonarQube, pois muitas regras também se concentram naqueles aspectos que começam a render muito depois de algum tempo.

### Tecnologias Utilizadas

Para a realização do projeto, foram utilizadas as seguintes tecnologias

* [DotNet Core](https://dotnet.microsoft.com)
* [Docker](https://www.docker.com/get-started)
* [Git](https://git-scm.com/downloads)
* [Git](https://gitlab.com)
* [SonarQube](https://www.sonarqube.org/developer-edition/?gclid=CjwKCAjwm_P5BRAhEiwAwRzSO3PQgoTSHjLDoTm1MjtxgbK7WjOraPwKTAea4xH74_Jkvf4fjztRbhoCS7gQAvD_BwE)

### Step

* Acessar o site [Play With Docker](https://labs.play-with-docker.com)
    * Requisito ter um usuário no Docker Hub.
* Clique em "Start".
* Clique em "Add New Instance".
* Selecione o terminal e execute os comandos abaixo.
    * git clone https://gitlab.com/WandersonAFreitas/seplag-sonarqube  
    * cd seplag-sonarqube
    * docker-compose up -d
        * Esse comando ira criar dois docker um para SonarQube e outra para banco de dados Postgres. 
    * docker ps
        * Esse comando permitirá verificar se os contêineres foram inicializado.
* Acesso o Play With Docker
* Clique em Open Port e informe a porta 9000.
* Será aberto uma nova guia do browser com link do SonarQube.
* Iniciar a sessão do SonarQube.
    * Usuário: admin
    * Senha: admin

* Acessar o link disponibilizado pelo PWD.
* Realizar o login do SonarQube.
        * Usuário: admin Senha: admin
    * Gerar um token para o projeto.
        * SeplagSonarQube
    * Selecione a linguagem C#




#### Links: 
    * https://medium.com/@cristianvitortrucco/utilizando-o-sonarqube-e-10-minutos-aa9de5749fb3
    * https://blog.setapp.pl/sonarqube_introduction
