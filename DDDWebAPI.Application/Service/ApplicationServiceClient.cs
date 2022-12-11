using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Application.Interfaces;
using DDDWebAPI.Domain.Core.Interfaces.Services;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DDDWebAPI.Application.Service
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient _serviceClient;
        private readonly IMapperClient _mapperClient;
     
        public ApplicationServiceClient(IServiceClient ServiceClient
                                                 , IMapperClient MapperClient)
                                              
        {
            _serviceClient = ServiceClient;
            _mapperClient = MapperClient;
        }


        public void Add(ClientDTO obj)
        {
            var objClient = _mapperClient.MapperToEntity(obj);
            _serviceClient.Add(objClient);
        }

        public void Dispose()
        {
            _serviceClient.Dispose();
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            var objProducts = _serviceClient.GetAll();
            return _mapperClient.MapperListClients(objProducts);
        }

        public ClientDTO GetById(int id)
        {
            var objClient = _serviceClient.GetById(id);
            return _mapperClient.MapperToDTO(objClient);
        }

        public void Remove(ClientDTO obj)
        {
            var objClient = _mapperClient.MapperToEntity(obj);
            _serviceClient.Remove(objClient);
        }

        public void Update(ClientDTO obj)
        {
            var objClient = _mapperClient.MapperToEntity(obj);
            _serviceClient.Update(objClient);
        }
    }
}
