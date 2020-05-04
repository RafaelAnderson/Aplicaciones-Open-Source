using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Model;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class ClientServiceImpl : IClientService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ClientServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ClientDto Create(ClientCreateDto model)
        {
            var entry = _mapper.Map<Client>(model);
            entry.SignedUpAt = DateTime.Now;

            _context.Add(entry);
            _context.SaveChanges();

            return _mapper.Map<ClientDto>(entry);
        }

        public DataCollection<ClientDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<ClientDto>>(
                _context.Clients
                .Include(x => x.Cards)
                .OrderByDescending(x => x.ClientId)
                .AsQueryable()
                .Paged(page, take)
                );
        }

        public ClientDto GetByUsernameAndPassword(string Username, string Password)
        {
            return _mapper.Map<ClientDto>(
                _context.Clients.Single(x => (x.Username == Username) && (x.Password == Password))
                );
        }

        public void Remove(int id)
        {
            _context.Remove(new Client
            {
                ClientId = id
            });

            _context.SaveChanges();
        }

        public void Update(int id, ClientUpdateDto model)
        {
            var entry = _context.Clients.Single(x => x.ClientId == id);
            entry.Name = model.Name;
            entry.Dni = model.Dni;
            entry.Email = model.Email;
            entry.Birthdate = model.Birthdate;
            entry.Username = model.Username;
            entry.Password = model.Password;

            _context.SaveChanges();
        }
    }
}
