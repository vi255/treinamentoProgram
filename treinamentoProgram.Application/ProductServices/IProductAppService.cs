using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using treinamentoProgram.ProductServices.DTOs;

namespace treinamentoProgram.ProductServices
{
    public interface IProductAppService : IApplicationService
    {
        Task<CreateProductOutput> CreateProduct(CreateProductInput input);
        Task<UpdateProductOutput> UpdateProduct(UpdateProductInput input);
        Task DeleteProduct(long id);
        Task<GetProductByIdOutput> GetByIdProduct(long id);
        Task<GetAllProductOutput> GetAllProducts();
    }
}
