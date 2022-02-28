using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_opcional_.Entites
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DataCriado { get; set; }
        public bool IsActive { get; set; }
        public DateTime DataExcluido { get; set; }
        
    }
}
