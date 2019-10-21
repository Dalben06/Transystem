using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transystem.Domain.Entitys;
using Transystem.Repository.Datas;
using Transystem.Repository.Interfaces;

namespace Transystem.Repository.Repositorys
{
    public class ClientRepository : IClientRepository
    {

        public TransystemContext _context { get; }

        public ClientRepository(TransystemContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        public void add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Client[]> GetAllClientAsync()
        {
            IQueryable<Client> query = _context.Client
                .Include(c => c.Addresses);


            query = query.OrderBy(x => x.Id);

            return await query.ToArrayAsync();
        }

    }
}
