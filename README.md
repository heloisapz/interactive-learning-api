# Interactive Learning API

API REST desenvolvida em .NET para uma plataforma de exercícios interativos com autenticação segura e recomendação adaptativa de dificuldade baseada em Machine Learning.

Este projeto faz parte de uma solução full-stack que inclui frontend web e mobile, consumindo a mesma API.

---

## 🎯 Objetivo

Fornecer uma API robusta e escalável que:
- Autentica usuários com JWT
- Gerencia exercícios e tentativas
- Registra métricas de desempenho
- Recomenda automaticamente a dificuldade dos exercícios utilizando Machine Learning

---

## 🧩 Funcionalidades (MVP)

- Cadastro e login de usuários
- Autenticação com JWT e Refresh Token
- Perfis de acesso (Aluno / Admin)
- CRUD de exercícios
- Registro de tentativas
- Cálculo de desempenho do usuário
- Recomendação de dificuldade via ML.NET
- Documentação com Swagger

---

## 🛠️ Stack Tecnológica

- .NET 8 (Web API)
- Entity Framework Core
- PostgreSQL
- JWT Authentication
- ML.NET
- Swagger / OpenAPI

---

## 🧠 Machine Learning

O sistema utiliza um modelo simples de classificação para recomendar a dificuldade ideal do próximo exercício com base em:
- Taxa de acerto
- Tempo médio de resposta
- Histórico recente de tentativas

O modelo roda dentro da própria API, sem dependência de serviços externos.

---

## 🏗️ Arquitetura

- API REST centralizada
- Clean Architecture
- Separação por camadas (Domain, Application, Infrastructure, API)
- DTOs e validações
- Autorização baseada em roles

---

## 🚀 Como executar localmente

```bash
git clone https://github.com/seu-usuario/interactive-learning-api.git
cd interactive-learning-api
dotnet restore
dotnet run
