using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transystem.Domain.Entitys;

namespace Transystem.Repository.Interfaces
{
    public interface IClientRepository
    {
        void add(Client entity);
        void Update(Client entity);
        void Delete(Client entity);

        Task<bool> SaveChangesAsync();

        Task<Client[]> GetAllClientAsync();

        Task<Client> GetClientByIdAsync(int Id);

        Task<Client[]> GetClientAsyncByName(string Name);
    }
}
