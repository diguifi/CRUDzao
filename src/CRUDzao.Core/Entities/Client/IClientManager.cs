using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDzao.Entities.Client
{
    public interface IClientManager
    {
        Task<long> Create(Client client);
        Task<Client> Update(Client client);
        Task Delete(long id);
        Task<Client> GetById(long id);
        Task<List<Client>> GetAll();
    }
}
