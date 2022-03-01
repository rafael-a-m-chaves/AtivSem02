using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DOMAIN.Entites;

namespace WebApplication.INFRA.Map
{
    public class UsuarioMap : BaseMap<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(r => r.Nome);
            builder.Property(r => r.Email);
            base.Configure(builder);
        }
    }
}
