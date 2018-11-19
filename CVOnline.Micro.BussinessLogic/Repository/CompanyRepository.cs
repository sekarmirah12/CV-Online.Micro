using CVOnline.Micro.Common.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVOnline.Micro.DataAccess.Models;
using CVOnline.Micro.DataAccess.Param;
using CVOnline.Micro.DataAccess.Context;

namespace CVOnline.Micro.BussinessLogic.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;

        public void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        public List<Company> Get()
        {
            return _context.Companies.ToList();
        }

        public Company Get(int? id)
        {
            if(id == null)
            {
                Console.Write("Id is null");
            }
            Company company = _context.Companies.Where(x => x.Id == id).SingleOrDefault();
            if(company == null)
            {
                Console.Write("Company has not value");
            }
            return company;
        }

        public bool Insert(CompanyParam companyParam)
        {
            throw new NotImplementedException();
        }

        public bool Update(CompanyParam companyParam)
        {
            throw new NotImplementedException();
        }
    }
}
