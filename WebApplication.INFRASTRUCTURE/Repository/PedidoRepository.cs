using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DOMAIN.Entites;
using WebApplication.INFRA.IRepository;

namespace WebApplication.INFRA.Repository
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {

        Context.Context context;
        public PedidoRepository(Context.Context ctx) : base(ctx)
        {
            context = ctx;
        }

    
    }
}
