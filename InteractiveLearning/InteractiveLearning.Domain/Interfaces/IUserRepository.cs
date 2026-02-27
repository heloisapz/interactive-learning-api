using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id);
        Task<User?> GetByEmailAsync(string email);
        Task AddAsync(User user);
        Task UpdateAsync(User user);

        //Task pois as operações de acesso a dados geralmente envolvem I/O, e o uso de async/await ajuda a melhorar a escalabilidade e a responsividade da aplicação, evitando bloqueios de thread durante operações de longa duração.

        
    }
}
