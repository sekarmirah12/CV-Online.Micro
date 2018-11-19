using CVOnline.Micro.Core;
using CVOnline.MicroMyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.MyModel
{
    public class Position : BaseModel
    {
        public string Name { get; set; }
        public Category categories { get; set; }
    }
}
