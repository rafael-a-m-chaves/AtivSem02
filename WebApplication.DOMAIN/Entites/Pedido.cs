using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DOMAIN.Entites
{
    public class Pedido: BaseEntity
    {
        public string Produto { get; set; }
        public double Valor { get; set; }


    }
}
