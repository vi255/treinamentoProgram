using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoProgram.ProductServices.DTOs
{
    public class UpdateProductInput : EntityDto<long>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
    }
}
