using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_opcional_.Entites;

namespace WebApplication_opcional_.Map
{
    public abstract class BaseMap<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.IsActive);
            builder.Property(r => r.DataCriado);
            builder.Property(r => r.DataExcluido);
        }
    }
}
