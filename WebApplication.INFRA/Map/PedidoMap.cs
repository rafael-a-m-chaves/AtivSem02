using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DOMAIN.Entites;

namespace WebApplication.INFRA.Map
{
    public class PedidoMap : BaseMap<Pedido>
    {
        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.Property(r => r.Produto);
            builder.Property(r => r.Valor);
            base.Configure(builder);
        }
    }
}
