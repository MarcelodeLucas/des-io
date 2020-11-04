using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sus.io.Models
{
    public class Pedido
    {
        public Guid id { get; set; }

        public Pedido()
        {
            id = Guid.NewGuid();
        }
        
    }
}
