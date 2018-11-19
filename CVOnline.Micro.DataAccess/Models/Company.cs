using CVOnline.Micro.Core;
using CVOnline.Micro.DataAccess.Param;
using CVOnline.Micro.MyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.DataAccess.Models
{
   public class Company : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Villages villages { get; set; }
        public Company() { }
        public Company(CompanyParam companyParam)
        {
            this.Name = companyParam.Name;
            this.Address = companyParam.Address;
            this.Username = companyParam.Username;
            this.Password = companyParam.Password;
            this.villages = companyParam.villages;
        }
        public virtual void Update(CompanyParam companyParam)
        {
            this.Id = companyParam.Id;
            this.Name = companyParam.Name;
            this.Address = companyParam.Address;
            this.Username = companyParam.Username;
            this.Password = companyParam.Password;
            this.villages = companyParam.villages;
        }
    }
}
