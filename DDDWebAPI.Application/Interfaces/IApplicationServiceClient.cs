using DDDWebAPI.Application.DTO.DTO;
using System.Collections.Generic;

namespace DDDWebAPI.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        void Add(ClientDTO obj);

        ClientDTO GetById(int id);

        IEnumerable<ClientDTO> GetAll();

        void Update(ClientDTO obj);

        void Remove(ClientDTO obj);

        void Dispose();

    }
}
