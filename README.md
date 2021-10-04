# SoftFinance

Contruído com

* .Net Core 3.1

Pré-Requisitos

* Realizar o download do .Net Core 3.1: "https://dotnet.microsoft.com/download/dotnet/3.1"

Instalação

1 - Git clone no diretório de sua preferência "https://github.com/agostinii/softfinance.git"

2 - Acessar o diretório via terminar

Realizar testes

1 - Acessar a pasta do projeto "cd .\SoftFinance.Tests\"

2 - Rodar os testes com o comenado "dotnet test"

Rodar API

1 - Acessar a pasta do projeto "cd .\SoftFinance.Api\"

2 - Buildar o projeto "dotnet build"

3 - Rodar o projeto "dotnet run"

4 - Por padrão a API sobe na url "http://localhost:5000"

5 - Acessar o swagger na url "http://localhost:5000/swagger"

Rodar pelo Docker

1 - Criar o diretório de destino ".\SoftFinance.Api\app"

2 - Rodar o comando "docker build -t softfinance -f Dockerfile ."

3 - Rodar o comando para rodar a imagem "docker run -d -p 5000:80 --name appsoftfinance softfinance"
