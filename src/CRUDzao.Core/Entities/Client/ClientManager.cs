using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDzao.Entities.Client
{
    public class ClientManager : IDomainService, IClientManager
    {
        private IRepository<Client, long> _clientRepository;

        public ClientManager(IRepository<Client, long> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<long> Create(Client client)
        {
            return await _clientRepository.InsertAndGetIdAsync(client);
        }

        public async Task<Client> Update(Client client)
        {
            return await _clientRepository.UpdateAsync(client);
        }

        public async Task Delete(long id)
        {
            await _clientRepository.DeleteAsync(id);
        }

        public async Task<Client> GetById(long id)
        {
            return await _clientRepository.GetAsync(id);
        }

        public async Task<List<Client>> GetAll()
        {
            return await _clientRepository.GetAllListAsync();
        }
    }
}
