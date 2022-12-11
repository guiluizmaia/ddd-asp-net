using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Core.Interfaces.Services;
using DDDWebAPI.Domain.Entity;

namespace DDDWebAPI.Domain.Services.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        public readonly IRepositoryClient _repositoryClient;

        public ServiceClient(IRepositoryClient RepositoryClient)
            : base(RepositoryClient)
        {
            _repositoryClient = RepositoryClient;
        }

    }
}
