using CVOnline.Micro.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.MyModel
{
    public class Client_Education : BaseModel
    {
        public Client clients { get; set; }
        public Education educations { get; set; }
    }
}
