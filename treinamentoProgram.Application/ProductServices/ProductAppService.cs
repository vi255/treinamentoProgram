using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using treinamentoProgram.Entities.Manager;
using treinamentoProgram.Entities.ProductEntity;
using treinamentoProgram.ProductServices.DTOs;

namespace treinamentoProgram.ProductServices
{
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private IProductManager _productManager;

        public ProductAppService(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public async Task<CreateProductOutput> CreateProduct(CreateProductInput input)
        {
            var produto = input.MapTo<Product>();
            var createProdutoId = await _productManager.Create(produto);
            return new CreateProductOutput
            {
                Id = createProdutoId
            };
        }

        public async Task DeleteProduct(long id)
        {
            await _productManager.Delete(id);
        }

        public async Task<GetAllProductOutput> GetAllProducts()
        {
            var produto = await _productManager.GetAllList();
            return new GetAllProductOutput { Products = Mapper.Map<List<GetAllProductItem>>(produto) };
        }

        public async Task<GetProductByIdOutput> GetByIdProduct(long id)
        {
            var produto = await _productManager.GetByIdProduct(id);
            return produto.MapTo<GetProductByIdOutput>();
        }

        public async Task<UpdateProductOutput> UpdateProduct(UpdateProductInput input)
        {
            var produto = input.MapTo<Product>();
            var produtoAtualizado = await _productManager.Update(produto);
            return produtoAtualizado.MapTo<UpdateProductOutput>();

        }

    }

   
}
