using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Domain.Entity;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace DDDWebAPI.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperProduct : IMapperProduct
    {

        #region Properties

        List<ProductDTO> productDTOs = new List<ProductDTO>();

        #endregion

        #region methods

        public Product MapperToEntity(ProductDTO productDTO)
        {
            Product product = new Product
            {

                Id = productDTO.Id,
                Name = productDTO.Name,
                Value = productDTO.Value,
                ClientId = productDTO.ClientId

            };

            return product;

        }

        public IEnumerable<ProductDTO> MapperListProducts(IEnumerable<Product> products)
        {
            foreach (var item in products)
            {

                ProductDTO productDTO = new ProductDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Value = item.Value,
                    ClientId = item.ClientId

                };

                productsDTOs.Add(productDTO);
            }


            return productsDTOs;

        }

        public ProductDTO MapperToDTO(Product product)
        {
            ProductDTO productDTO = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value,
                ClientId = product.ClientId

            };

            return productDTO;

        }

        #endregion
    }
}
