using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using treinamentoProgram.Entities.ProductEntity;

namespace treinamentoProgram.Entities.Manager
{
    public class ProductManager : IDomainService, IProductManager
    {
        private IRepository<Product, long> _productRepository;

        public ProductManager(IRepository<Product, long> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<long> Create(Product produto)
        {
            return await _productRepository.InsertAndGetIdAsync(produto);// insere dados desde objeto na respectiva tabela do BD.
        }

        public async Task Delete(long id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<List<Product>> GetAllList()
        {
            return await _productRepository.GetAllListAsync();
        }

        public async Task<Product> GetByIdProduct(long id)
        {
            return await _productRepository.GetAsync(id);
        }

        public async Task<Product> Update(Product produto)
        {
            return await _productRepository.UpdateAsync(produto);
        }
    }
}
