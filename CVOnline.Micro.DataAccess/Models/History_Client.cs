﻿using CVOnline.Micro.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOnline.Micro.MyModel
{
   public class History_Client : BaseModel
    {
       public Client client { get; set; }
       public Job_Detail job_detail { get; set; }
    }
}
