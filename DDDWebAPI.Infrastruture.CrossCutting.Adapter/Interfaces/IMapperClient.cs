using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Entity;
using System.Collections.Generic;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperClient
    {
        #region Mappers

        Client MapperToEntity(ClientDTO clientDTO);

        IEnumerable<ClientDTO> MapperListClients(IEnumerable<Client> clients);

        ClientDTO MapperToDTO(Client Client);

        #endregion

    }
}
