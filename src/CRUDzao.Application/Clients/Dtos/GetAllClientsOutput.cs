using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDzao.Clients.Dtos
{
    public class GetAllClientsOutput
    {
        public List<GetAllClientsItem> Clients { get; set; }
    }
}
