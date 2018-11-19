using CVOnline.Micro.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.MyModel
{
   public class Client : BaseModel
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        public string Cv { get; set; }
        public string Ktp { get; set; }
        public string Foto { get; set; }
        public Villages villages { get; set; }
    }
}
