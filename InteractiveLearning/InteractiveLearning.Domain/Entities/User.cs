using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; } //Guid para garantir unicidade global
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public UserRole Role { get; private set; }
        public DateTime CreatedAt { get; private set; }

        // Construtor protegido para EF Core
        protected User() { } //protected para evitar criação direta sem validação

        public User(string nome, string email, string passwordHash, UserRole role)  //Construtor para criação de novos usuários, garantindo que todas as propriedades necessárias sejam definidas
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
            CreatedAt = DateTime.UtcNow; //UtcNow para evitar problemas de fuso horário
        }

        public void UpdatePassword(string newPasswordHash) //Método para atualizar a senha, garantindo que a lógica de atualização seja centralizada
        {
            PasswordHash = newPasswordHash;
        }

        public void ChangeRole(UserRole newRole)
        {
            Role = newRole;
        }
    }
}
