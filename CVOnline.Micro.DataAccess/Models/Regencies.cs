using CVOnline.Micro.Core;
using CVOnline.Micro.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.MyModel
{
    public class Regencies : BaseModel
    {
        public string Name { get; set; }
        public Provinces provinces { get; set; }
    }
}
