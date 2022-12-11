using DDDWebAPI.Application.DTO.DTO;
using DDDWebAPI.Application.Interfaces;
using DDDWebAPI.Domain.Core.Interfaces.Services;
using DDDWebAPI.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace DDDWebAPI.Application.Service
{
    public class ApplicationServiceProduct : IDisposable, IApplicationServiceProduct
    {
        private readonly IServiceProduct _serviceProduct;
        private readonly IMapperProduct _mapperProduct;

        public ApplicationServiceProduct(IServiceProduct ServiceProduct
                                         , IMapperProduct MapperProduct)
        {
            _serviceProduct = ServiceProduct;
            _mapperProduct = MapperProduct;
        }

        public void Add(ProductDTO obj)
        {
            var objProduct = _mapperProduct.MapperToEntity(obj);
            _serviceProduct.Add(objProduct);
        }

        public void Dispose()
        {
            _serviceProduct.Dispose();
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var objProducts = _serviceProduct.GetAll();
            return _mapperProduct.MapperListProducts(objProducts);
        }

        public ProductDTO GetById(int id)
        {
            var objProduct = _serviceProduct.GetById(id);
            return _mapperProduct.MapperToDTO(objProduct);
        }

        public void Remove(ProductDTO obj)
        {
            var objProduct = _mapperProduct.MapperToEntity(obj);
            _serviceProduct.Remove(objProduct);
        }

        public void Update(ProductDTO obj)
        {
            var objProduct = _mapperProduct.MapperToEntity(obj);
            _serviceProduct.Update(objProduct);
        }

    }
}
