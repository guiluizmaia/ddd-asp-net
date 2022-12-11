using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Entity;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperClient : IMapperClient
    {

        #region properties

        List<ClientDTO> clientDTOs = new List<ClientDTO>();

        #endregion


        #region methods

        public Client MapperToEntity(ClientDTO clientDTO)
        {
            Client client = new Client
            {
                Id = clientDTO.Id,
                Name = clientDTO.Name,
                LastName = clientDTO.LastName,
                Email = clientDTO.Email,
                CreatedAt = clientDTO.CreatedAt
            };

            return client;

        }


        public IEnumerable<ClientDTO> MapperListClients(IEnumerable<Client> clients)
        {
            foreach (var item in clients)
            {


                ClientDTO clientDTO = new ClientDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    LastName = item.LastName,
                    Email = item.Email,
                    CreatedAt = item.CreatedAt
                };



                clientDTOs.Add(clientDTO);

            }

            return clientDTOs;
        }

        public ClientDTO MapperToDTO(Client client)
        {

            ClientDTO clientDTO = new ClientDTO
            {
                Id = Client.Id,
                Name = Client.Name,
                LastName = Client.LastName,
                Email = Client.Email,
                CreatedAt = Client.CreatedAt
            };

            return clientDTO;

        }

        #endregion

    }
}
