# Seplag SonarQube

## Desenvolvimento de uma POC do SonarQube para Seplag

#### O que é SonarQube?

* SonarQube é uma plataforma de código aberto para realizar revisões automáticas com análise estática de código para detectar bugs, possíveis problemas e vulnerabilidades de segurança. O SonarQube permite análisar mais de 25 linguagens de programação.

#### Que tipo de valor o SonarQube traz?

* Ajuda a detectar muitos problemas no código, ajuda a corrigir os problemas assim que eles aparecem.
* Manter o código limpo, simples e fácil de ler, pois muitas regras também se concentram naqueles aspectos que começam a render muito depois de algum tempo.

### Tecnologias Utilizadas

Para a realização do projeto, foram utilizadas as seguintes tecnologias

* [DotNet Core](https://dotnet.microsoft.com)
* [Docker](https://www.docker.com/get-started)
* [Git](https://git-scm.com/downloads)
* [Git](https://gitlab.com)
* [SonarQube](https://www.sonarqube.org/developer-edition/?gclid=CjwKCAjwm_P5BRAhEiwAwRzSO3PQgoTSHjLDoTm1MjtxgbK7WjOraPwKTAea4xH74_Jkvf4fjztRbhoCS7gQAvD_BwE)

### Step

* Acessar o site [Play With Docker](https://labs.play-with-docker.com)
    * Requisito ter um usuário no Docker Hub
* Clique em "Start"
* Clique em "Add New Instance"
* Selecione o terminal e execute os comandos abaixo
    * git clone https://gitlab.com/WandersonAFreitas/seplag-sonarqube  
    * cd seplag-sonarqube
    * docker-compose up -d
        * Esse comando ira criar dois docker um para SonarQube e outra para banco de dados Postgres. 
    * docker ps
        * Esse comando permitirá verificar se os contêineres foram inicializado.
* Acesso o Play With Docker
* Clique em Open Port e informe a porta 9000.
* Será aberto uma nova guia no browser com link do SonarQube
* Iniciar a sessão do SonarQube.
    * Usuário: admin
    * Senha: admin
* Informer no input "SeplagSonarQube" e clique em gerar Token
* Anotar o token gerado "b1a75b123e87c63c8b328b3345dfd347b830f184"
* Selecione a Linguaem que deverá ser monitorada
    * C# or VB.NET
* Informe nome do projeto "SeplagSonarQube"
* Acesso o projeto do GitLab
* Acesse o Settings > CI / CD > Variables
* Editar as variaveis abaixo.
    * SONAR_TOKEN - Informe o novo Token gerado no SonarQube.
    * SONAR_URL - Informe o link do PWD (Exemplo: http://ip172-18-0-161-bsui16lim9m000d4eri0-9000.direct.labs.play-with-docker.com/)
* Acesse o CI / CD > Pipelines
* Clique em Run Pipelines
* Após o termino da análise, acesso o site do SonarQube

#### Links: 

* https://medium.com/@cristianvitortrucco/utilizando-o-sonarqube-e-10-minutos-aa9de5749fb3
* https://blog.setapp.pl/sonarqube_introduction
