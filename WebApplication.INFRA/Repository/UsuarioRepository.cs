using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DOMAIN.Entites;
using WebApplication.INFRA.IRepository;

namespace WebApplication.INFRA.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {

        Context.Context context;
        public UsuarioRepository(Context.Context ctx) : base(ctx)
        {
            context = ctx;
        }

    }
}
