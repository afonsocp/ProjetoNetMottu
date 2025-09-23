NeoMoto API (Minimal API .NET 8)

Descrição
NeoMoto é uma API RESTful para gestão da frota da Mottu (motos), organizada por filiais e com histórico de manutenções.

Domínio e entidades
- Filiais: unidades físicas que organizam a frota.
- Motos: veículos associados a uma filial, com placa única.
- Manutenções: eventos de manutenção vinculados a uma moto.

Boas práticas atendidas
- CRUD completo para 3 entidades.
- Paginação (pageNumber, pageSize) e HATEOAS com links self/rel.
- Status codes adequados (200/201/204/400/404).
- Swagger/OpenAPI com descrições e exemplos.

Requisitos
- .NET SDK 8.0+

Como executar
1. Restaurar e compilar:
   dotnet restore
   dotnet build
2. Rodar API:
   dotnet run --project NeoMoto.Api/NeoMoto.Api.csproj --urls http://localhost:5010
3. Abrir Swagger:
   http://localhost:5010/swagger

Banco de dados
- SQLite (arquivo neomoto.db). Criado/migrado automaticamente no startup.

Exemplos de uso
- Listar motos (paginação):
  GET /api/motos?pageNumber=1&pageSize=10
- Criar filial:
  POST /api/filiais
  { "nome":"Filial Centro", "endereco":"Rua A, 100", "cidade":"São Paulo", "uf":"SP" }

Testes
- Executar:
  dotnet test

Arquitetura
- Minimal API (NeoMoto.Api) + Domain (entidades) + Infrastructure (EF Core SQLite, DbContext).
- Justificativa: simplicidade, performance, menor boilerplate, boa extensão via endpoints.

Integrantes 
- Afonso Correia Pereira - RM557863
- Adel Mouhaidly - RM557705
- Tiago Augusto Desiderato - RM558485

Publicação
- Inicie o repositório git e publique no GitHub:
  git init
  git add .
  git commit -m "NeoMoto API inicial"
  git branch -M main
  git remote add origin <url-do-seu-repo>
  git push -u origin main

