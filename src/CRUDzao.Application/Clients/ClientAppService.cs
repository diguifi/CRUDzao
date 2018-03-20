using Abp.AutoMapper;
using Abp.Modules;
using CRUDzao.Clients.Dtos;
using CRUDzao.Entities.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDzao.Clients
{
    //[DependsOn(typeof(CRUDzaoCoreModule), typeof(AbpAutoMapperModule))]
    public class ClientAppService : IClientAppService
    {
        private IClientManager _clientManager;

        public ClientAppService(IClientManager clientManager)
        {
            _clientManager = clientManager;
        }

        public async Task<CreateClientOutput> CreateClient(CreateClientInput input)
        {
            var client = input.MapTo<Client>(); //mapeia o input para o tipo Client
            var createdClientId = await _clientManager.Create(client); //como a funcao no repositorio eh "createandgetID", ao criar o client, um Id eh retornado e passado a variavel
            return new CreateClientOutput
            {
                Id = createdClientId //o output usa a nova id para mostrar o novo Client
            }; 
        }

        public async Task DeleteClient(long id)
        {
            await _clientManager.Delete(id);
        }

        public async Task<GetAllClientsOutput> GetAllClients()
        {
            var clients = await _clientManager.GetAll();
            return new GetAllClientsOutput
            {
                Clients = clients.MapTo<List<GetAllClientsItem>>()
            };
        }

        public async Task<GetClientByIdOutput> GetById(long id)
        {
            var client = await _clientManager.GetById(id);
            return client.MapTo<GetClientByIdOutput>();
        }

        public async Task<UpdateClientOutput> UpdateClient(UpdateClientInput input)
        {
            var client = input.MapTo<Client>();
            var clientUpdated = await _clientManager.Update(client);
            return clientUpdated.MapTo<UpdateClientOutput>();
        }
    }
}

