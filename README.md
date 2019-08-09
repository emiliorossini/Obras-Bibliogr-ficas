# Teste de Emilio Nicolau Rossini de Oliveira
* Linkedin: https://www.linkedin.com/in/emílio-rossini-6400a621/

# Tecnologias utilizadas

* Angular
* NET CORE 2.2
* DDD
* EF Core com Migrations (com seed de banco de 6 autores)
* SQL SERVER
* Injeção de dependência
* Testes de unidade

## IMPORTANTE! Connection string

* Abrir a solução e ajustar a connection string
* Connection string está no Projeto 0-Presentation -> TesteConquest.Site -> appsettings.json:
  "ConnectionStrings": {
    "ConquestContext": "Server=EMILIO-NOTE; Database=TesteConquest; User Id=sa; Password=123456; MultipleActiveResultSets=true; Connection Timeout=999;"
  },  
  
* Migration automatico ao rodar o site!

## Execução do projeto

* Localize o "caminho" do TesteConquest\src\TesteConquest.Site
* Pode ser executado o site pelo comando dotnet run --project "caminho" e depois acessar o browser com https://localhost:5001/
* Pode ser executado também abrindo a solution TesteConquest\TesteConquest.sln e rodar o projeto 0-Presentation -> TesteConquest.Site

*Acesse o menu Autores, inclua o número de autores que deseja buscar e depois pressione o botão "Buscar autores" (máximo incial é 6, pois existem 6 autores pré-cadastrados)
