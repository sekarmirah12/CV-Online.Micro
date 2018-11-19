using CVOnline.Micro.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.MyModel
{
    public class Interview : BaseModel
    {
        public DateTimeOffset Schedule { get; set; }
        public string Result { get; set; }
        public Villages villages { get; set; }
    }
}
