using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_opcional_.Entites;
using WebApplication_opcional_.IRepository;
using WebApplication_opcional_.IService;

namespace WebApplication_opcional_.Service
{
    public class PedidoService : BaseService<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository repository;
        public PedidoService(IPedidoRepository _repository) : base(_repository)
        {
            repository = _repository;
        }


        
    }
}
