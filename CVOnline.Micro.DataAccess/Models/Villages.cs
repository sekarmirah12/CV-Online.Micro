using CVOnline.Micro.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.MyModel
{
    public class Villages :BaseModel
    {
        public string Name { get; set; }
        public Districts districts { get; set; }
    }
}
