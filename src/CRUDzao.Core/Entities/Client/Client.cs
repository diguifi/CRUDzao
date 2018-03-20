using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDzao.Entities.Client
{
    public class Client : FullAuditedEntity<long>
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

        public Client()
        {
            this.CreationTime = DateTime.Now;
        }

        public Client(string firstName, string lastName, string city, string adress, int number, string email, int phone, DateTime birth, float height, float weight)
        {
            this.CreationTime = DateTime.Now;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Adress = adress;
            this.Number = number;
            this.Email = email;
            this.Phone = phone;
            this.Birth = birth;
            this.Height = height;
            this.Weight = weight;
    }
    }
}
