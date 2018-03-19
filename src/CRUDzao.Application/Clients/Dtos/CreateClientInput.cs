using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDzao.Clients.Dtos
{
    public class CreateClientInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime Birth { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

    }
}
