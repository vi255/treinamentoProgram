using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using treinamentoProgram.Entities.ProductEntity;

namespace treinamentoProgram.Entities.Manager
{
    public interface IProductManager
    {
        Task<long> Create(Product produto);
        Task<Product> Update(Product produto);
        Task Delete(long id);
        Task<Product> GetByIdProduct(long id);
        Task<List<Product>> GetAllList();
    }
}
