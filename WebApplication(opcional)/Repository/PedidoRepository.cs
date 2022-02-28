using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_opcional_.Entites;
using WebApplication_opcional_.IRepository;

namespace WebApplication_opcional_.Repository
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {

        Context.Context context;
        public PedidoRepository(Context.Context ctx) : base(ctx)
        {
            context = ctx;
        }

    {
    }
}
