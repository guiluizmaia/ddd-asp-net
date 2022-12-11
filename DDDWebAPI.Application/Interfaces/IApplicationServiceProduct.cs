using DDDWebAPI.Application.DTO.DTO;
using System.Collections.Generic;

namespace DDDWebAPI.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDTO obj);

        ProductDTO GetById(int id);

        IEnumerable<ProductDTO> GetAll();

        void Update(ProductDTO obj);

        void Remove(ProductDTO obj);

        void Dispose();

    }
}
