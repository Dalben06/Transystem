﻿using Microsoft.EntityFrameworkCore;
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


        public void add(Client entity)
        {
            entity.CreateDate = entity.UpdateDate = DateTime.Now;
            _context.Add(entity);
        }
        public void Update(Client entity) 
        {
            entity.UpdateDate = DateTime.Now;
            _context.Update(entity);
        }
        public void Delete(Client entity)
        {
            _context.Update(entity)
                .Entity.IsDeleted = 1;
            _context.Update(entity)
                .Entity.DeleteDate = DateTime.Now;

        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Client[]> GetAllClientAsync()
        {
            IQueryable<Client> query = _context.Client
                .Include(c => c.Addresses);


            query = query.OrderBy(x => x.Id).Where(x => x.IsDeleted == 0);

            return await query.ToArrayAsync();
        }

        public async Task<Client> GetClientByIdAsync(int Id)
        {
            IQueryable<Client> query = _context.Client
                .Include(c => c.Addresses);
            query = query.Where(x => x.Id == Id);
            query = query.Where(x => x.IsDeleted == 0);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Client[]> GetClientAsyncByName(string Name)
        {
            IQueryable<Client> query = _context.Client
                .Include(c => c.Addresses);

            query = query.Where(x => x.Name.ToLower().Contains(Name.ToLower()));
            query = query.Where(x => x.IsDeleted == 0);

            return await query.ToArrayAsync();
        }


    }
}
