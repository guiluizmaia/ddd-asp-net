using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Entity;
using DDDWebAPI.Infrastructure.Data;

namespace DDDWebAPI.Infrastruture.Repository.Repositorys
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {

        private readonly SqlContext _context;
        public RepositoryProduct(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}
