# 🚀 SupportAI - Sistema de Triagem Inteligente com IA

O **SupportAI** é uma solução completa de backend para automação de suporte ao cliente. O sistema captura tickets via Webhook, utiliza Inteligência Artificial para análise de sentimento e resumo de problemas, e armazena tudo de forma estruturada em um banco de dados relacional.

---

## 🛠️ Tecnologias Utilizadas

Este projeto demonstra a integração de tecnologias modernas de Backend, No-Code e IA:

* **Linguagem & Framework:** [C# / .NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* **Orquestração de Fluxo:** [n8n](https://n8n.io/)
* **Inteligência Artificial:** [Google Gemini / Hugging Face](https://deepmind.google/technologies/gemini/) (NLP para análise de sentimentos e resumo)
* **Banco de Dados:** [SQLite](https://www.sqlite.org/index.html) com [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) (Code-First)
* **Notificações:** [Telegram Bot API](https://core.telegram.org/bots)

---

## 🏗️ Arquitetura do Sistema

O fluxo de dados segue o seguinte percurso:

1.  **Ingestão:** Um Webhook recebe um JSON com o e-mail do cliente e o problema relatado.
2.  **Processamento (IA):** O n8n envia o relato para a IA, que identifica o estado emocional do cliente e cria um resumo técnico.
3.  **Backend (.NET 8):** O n8n formata o dado e envia uma requisição POST para a nossa API REST.
4.  **Persistência:** O Backend utiliza o **Entity Framework Core** para gravar o ticket permanentemente no SQLite.
5.  **Alertas:** Simultaneamente, o n8n notifica a equipe via Telegram sobre o novo chamado processado.

---

## 🚀 Como Executar o Projeto

### Pré-requisitos
* SDK do .NET 8
* n8n instalado (Local ou Cloud)

### 1. Configurando o Backend
Clone o repositório e navegue até a pasta da API:
```bash
# Instalar dependências
dotnet restore

# Executar as migrations para criar o banco SQLite
dotnet ef database update

# Rodar a aplicação
dotnet run
