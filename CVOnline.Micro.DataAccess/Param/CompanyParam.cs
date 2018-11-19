using CVOnline.Micro.DataAccess.Models;
using CVOnline.Micro.MyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.DataAccess.Param
{
    public class CompanyParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Villages villages { get; set; }
        public CompanyParam()
        {

        }
        public CompanyParam(Company company)
        {
            Id = company.Id;
            Name = company.Name;
            Address = company.Address;
            Username = company.Username;
            Password = company.Password;
            villages = company.villages;
        }
    }
}
