using CVOnline.Micro.DataAccess.Models;
using CVOnline.Micro.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.Common.Interfaces.Application
{
    public interface ICompanyRepository
    {
        List<Company> Get();
        Company Get(int? id);
        bool Insert(CompanyParam companyParam);
        bool Update(CompanyParam companyParam);
        void Dispose(bool disposing);
    }
}
