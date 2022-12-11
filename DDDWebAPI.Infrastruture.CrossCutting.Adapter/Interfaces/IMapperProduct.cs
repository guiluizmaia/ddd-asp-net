using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Entity;
using System.Collections.Generic;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperProduct
    {
        #region Interfaces Mappers
        Product MapperToEntity(ProductDTO productDTO);

        IEnumerable<ProductDTO> MapperListProducts(IEnumerable<Product> products);

        ProductDTO MapperToDTO(Product product);

        #endregion

    }
}
