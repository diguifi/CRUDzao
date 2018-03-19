using Abp.Application.Services;
using CRUDzao.Clients.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDzao.Clients
{
    public interface IClientAppService : IApplicationService
    {
        Task<CreateClientOutput> CreateClient(CreateClientInput input);
        Task<UpdateClientOutput> UpdateClient(UpdateClientInput input);
        Task DeleteClient(long id);
        Task<GetClientByIdOutput> GetById(long id);
        Task<GetAllClientsOutput> GetAllClients();
    }
}
