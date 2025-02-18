# 🛡️ Identity EF Core - Estudos

Bem-vindo ao repositório de estudos sobre **Identity com Entity Framework Core** no **.NET 6.0**! 🎯🚀

## 📌 Objetivo

Este projeto tem como objetivo explorar e aprender sobre o uso do **Identity** no **Entity Framework Core** para controle de usuários, autenticação e autorização em aplicações .NET.

## 🛠️ Tecnologias Utilizadas

- ⚙️ **.NET 6.0**
- 🎢 **Entity Framework Core**
- 🔑 **Identity Framework**
- 🟢 **Banco de Dados MySql**
- 🔄 **Migrations do EF Core**

## 🚀 Como Executar o Projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/gu-lemos/usuarios-api.git
   ```

2. Acesse a pasta do projeto:

   ```bash
   cd UsuariosApi
   ```

3. Instale as dependências:

   ```bash
   dotnet restore
   ```

4. Configure as secrets da aplicação com os seguintes comandos:

   ```bash
   dotnet user-secrets set "SymmetricSecurityKey" "SEU_VALOR_AQUI"
   dotnet user-secrets set "ConnectionStrings:UsuarioConnection" "SEU_VALOR_AQUI"
   ```

   **Nota:** Substitua `SEU_VALOR_AQUI` pelos valores reais, garantindo que permaneçam seguros e fora do controle de versão.

5. Aplique as migrations:

   ```bash
   dotnet ef database update
   ```

6. Execute a aplicação:

   ```bash
   dotnet run
   ```

## 📚 O que estou estudando neste projeto?

- 🔹 Configuração do Identity no EF Core
- 🔹 Criação e gestão de usuários e roles
- 🔹 Customização de tabelas do Identity
- 🔹 Geração de tokens para autenticação
- 🔹 Implementação de autenticação JWT

## 💡 Contribuição

Este projeto é apenas para estudos, mas qualquer sugestão ou melhoria é sempre bem-vinda! Sinta-se livre para abrir issues ou pull requests. 😊

## 🐜 Licença

Este repositório é para fins de estudo e não possui uma licença definida.

---

📌 **Mantenha-se curioso e continue aprendendo!** 🚀🎓