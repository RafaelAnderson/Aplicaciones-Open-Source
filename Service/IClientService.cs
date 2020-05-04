using PointFood.Commons;
using PointFood.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service
{
    public interface IClientService
    {
        ClientDto Create(ClientCreateDto model);
        DataCollection<ClientDto> GetAll(int page, int take);
        ClientDto GetByUsernameAndPassword(string Username, string Password);
        void Update(int id, ClientUpdateDto model);
        void Remove(int id);
    }
}
