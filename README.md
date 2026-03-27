# 🛒 Purchase Order API - Desafio Técnico

## 📌 Descrição

Este projeto tem como objetivo implementar uma API para gerenciamento de pedidos de compra com fluxo de aprovação baseado em alçadas de valor.

O sistema simula um cenário corporativo onde pedidos passam por diferentes níveis de aprovação (Suprimentos, Gestor e Diretor), podendo sofrer revisões durante o processo.

---

## 🧠 Modelagem da Solução

A modelagem foi baseada nas regras de negócio fornecidas no desafio, com foco em separação de responsabilidades e rastreabilidade do processo.

### 🔹 Principais entidades:

* **PurchaseOrder**: representa o pedido de compra
* **OrderItem**: itens do pedido
* **Approval**: etapas de aprovação sequencial
* **OrderHistory**: histórico de ações do pedido
* **User**: usuários do sistema (Colaboradores)

---

## 🔄 Fluxo de Aprovação

O fluxo de aprovação é definido com base no valor total do pedido:

* Até R$100 → aprovação por Suprimentos
* Até R$1000 → Suprimentos + Gestor
* Acima de R$1000 → Suprimentos + Gestor + Diretor

O processo segue de forma **sequencial**, e pode ser reiniciado em caso de solicitação de revisão.

---

## 🧱 Arquitetura

A aplicação foi estruturada seguindo princípios de separação de camadas:

* **Controllers**: recebem as requisições HTTP
* **Services**: responsáveis pela lógica de negócio
* **Domain (Entities)**: representam o modelo do sistema
* **Data**: acesso ao banco via Entity Framework

---

## ⚙️ Tecnologias utilizadas

* .NET SDK 10.0 (C#)
* Entity Framework Core
* SQL Server

---

## ▶️ Como executar o projeto

### 📋 Pré-requisitos

Antes de iniciar, é necessário ter instalado:

* [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/)
* SQL Server (ou SQL Server Express)
* (Opcional) Visual Studio ou VS Code

---

### 🚀 Passo a passo

1. Clone o repositório:

```bash
git clone <URL_DO_REPOSITORIO>
```

2. Acesse a pasta do projeto:

```bash
cd <NOME_DO_PROJETO>
```

3. Restaure as dependências:

```bash
dotnet restore
```

4. Configure a string de conexão com o banco de dados no arquivo:

```text
appsettings.json
```

Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=PurchaseOrderDb;Trusted_Connection=True;"
}
```

5. Execute as migrations (caso estejam configuradas):

```bash
dotnet ef database update
```

6. Execute a aplicação:

```bash
dotnet run
```

A API estará disponível em:

```text
https://localhost:5250
ou
https://localhost:7152
```

---

## 🧪 Como testar o endpoint implementado

Atualmente, devido a falta de tempo disponível para atuação ativa no desafio, foi implementado o endpoint de criação de usuário.

---

### 📌 Criar usuário

**Endpoint:**

```http
POST /users
```

---

### 📥 Exemplo de requisição (JSON)

```json
{
  "name": "João Silva",
  "role": 1
}
```

---

### 📤 Resposta esperada

```bash

  Usuario criado com sucesso.

```

---

### 🛠️ Como testar

Você pode utilizar:

* Postman
* Insomnia
* O endpoint `https://localhost:{7152}/swagger/index.html` gerado pela extensão Swagger.UI
---

## 🚧 Status do desenvolvimento e desafios

Infelizmente devido à minha limitação de tempo, a implementação completa da API não foi finalizada. Procurei focar principalmente na criação dos diagramas de atividades e classes da solução, pois considerei que fazendo-os teria uma visão melhor e mais contextualizada do problema a ser resolvido. Não consegui modelar o diagrama físico de bancos de dados pois, pelo tempo, decidi partir para a implementação. Entendi que fazia mais sentido construir a solução em uma arquiterura dividida em camadas de responsabilidade, com isso, busquei representá-las através das pastas Controller, Application, Domain e Infrastructure.

Atualmente, foi implementado:

* A pasta `Application` se divide em 3 sub-diretórios:
  * **DTOs**: Objetos responsáveis por transferir dados das entidades entre as camadas da aplicação.
  * **Interfaces**: Define o que deve ser feito pela entidade.
  * **Repository**: Realiza a persistência dos dados no banco de dados através de métodos nativos do Entity Framework Core.
  * **Services**: Implementação da lógica de negócios da aplicação. Neste caso, é uma pasta vazia pois entendi que a entidade User não teria, neste contexto, uma lógica de negócios complexa o suficiente para essa divisão.
* A pasta `Controllers` contém os arquivos controladores que tratam da recepção e redirecionamento de requisições HTTP, é com ela que conversamos primeiro ao fazer um POST /user.
* A pasta `Domain` se divide em 3 sub-diretórios:
  * **Entities**: Contém os arquivos para definição das principais classes da aplicação.
  * **Enums**: Utilizei enumerações para simplificar o processo de classificação / organização de algumas variáveis que podem assumir diferentes valores.
* A pasta `Infrastructure` possui os arquivos necessários para conexão, mapeamento das entidades da aplicação e tabelas e versionamento do banco de dados.

---

## 📌 O que eu faria se tivesse mais tempo? 

Os próximos passos seriam:

* Criar endpoint POST /order para criar pedidos
* Implementar cálculo do valor total do pedido
* Implementar lógica das alçadas de votação com base no valor total do pedido
* Implementar lógica de cancelamento e revisão de pedido
* Criar collection no Postman para testes automatizados

---

### 💙🧡 Considerações finais
## 💬 Considerações finais

Devido ao tempo disponível e à conciliação com outras atividades acadêmicas e domésticas, não consegui concluir a implementação conforme planejado.
Porém busquei priorizar a compreensão do problema e a construção de uma base interessante de modelagem, garantindo que os principais requisitos estivessem bem expostos e coerentes com o esperado.
Acredito que a solução apresentada reflete minha capacidade de análise, organização e estruturação de sistemas, mesmo que nem todos os pontos tenham sido implementados na prática.

Fico à disposição uma eventual conversa técnica onde possa detalhar as decisões que tomei, explicar como evoluiria a implementação e discutir possíveis melhorias, pois acredito ter o potencial para amadurecer meus conhecimentos com vocês.
Agradeço pela oportunidade e pelo desafio. :D

---
