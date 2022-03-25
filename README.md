# JslApi
API Web para manter a camada de dados do projeto de Teste.

Utilizando inicialmente PostgreSQL, pois ainda não consegui configurar corretamente o Oracle em meu PC.

Tempo de desenvolvimento dessa API: Em torno de 1 hora e 30 minutos.

Principais dificuldades:
* Aprender o framework ASP.NET MVC, pois já tinha um conhecimento anterior em C#, então o foco foi aprender as particularidades de utilização do framework.
* Conseguir fazer a primeira vez o relacionamento entre os modelos, pois nunca havia utilizado o EntityFramework.
* Conseguir utilizar o Oracle Database Express Edition (21c). Apesar de já ter baixado e instalado, ainda não consegui compreender exatamente como devo manusear e desenvolver com essa ferramenta, talvez por estar muito acostumado com o PostgreSQL e suas ferramentas de utilização, frisando que a linguagem, pelo que estudei, tem suas particularidades, mas não é esse o ponto de dificuldade.

Observações interessantes:
* Com o conhecimento que eu possuo em Angular e RoR, tive facilidade de identificar e entender:
  * Conceitos utilizados no ASP.NET Core MVC, onde as camadas são bem definidas e existem formas de comunicação entre o controle e a view
  * A utilização de migrations para controle de alterações no Banco de Dados.
  * Como deveria funcionar basicamente uma API.
* Levei mais tempo estudando e fazendo diversos projetos de teste do que efetivamente desenvolvendo a solução quando me senti confiante no que havia aprendido até o momento.
* Meu conhecimento nas ferramentas solicitadas no teste era praticamente nulo, e fiquei satisfeito com o aprendizado que foi proporcionado.

Passos utilizados:
* Criação dos Models (Motorista e Viagem).
* Criação da Classe de Contexto.
* Criação dos Controllers, baseados nos models, e utilizando a classe de Contexto.
* Adicionados os pacotes:
  * Npgsql.EntityFrameworkCore.PostgreSQL (para utilizar o PostgreSQL)
  * Microsoft.EntityFrameworkCore
* Alteração do appsettings.json:
  * Adicionada ConnectionString para o banco de dados que é utilizado.
* Alteração do Program.cs:
  * Adicionada a leitura da configuração criada acima para utilização do Contexto.
* Criadas as migrations:
  * Add-Migration NOME_MIGRATION -Contexto CLASSE_CONTEXTO
* Realizadas as alterações no Banco de Dados:
  * Update-Database
* Para realizar os testes da API enquanto não implemento a solução que consumirá a API, utilizei o Postman.
