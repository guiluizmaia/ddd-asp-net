using Autofac;
using DDDWebAPI.Application.Interfaces;
using DDDWebAPI.Application.Service;
using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Core.Interfaces.Services;
using DDDWebAPI.Domain.Services.Services;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map;
using DDDWebAPI.Infrastruture.Repository.Repositorys;

namespace DDDWebAPI.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<IServiceProduct>().As<IServiceProduct>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();
            #endregion

            #endregion

        }
    }
}
