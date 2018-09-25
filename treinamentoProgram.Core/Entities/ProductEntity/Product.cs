using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamentoProgram.Entities.ProductEntity
{
    public class Product : FullAuditedEntity<long>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }

        public Product()
        {
            this.CreationTime = DateTime.Now;
        }

        public Product(string nome, string descricao, float valor)
        {
            this.CreationTime = DateTime.Now;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Valor = valor;

        }
    }

    
}
