using ProdutosAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Tamanho { get; set; }
        public int Quantidade { get; set; }
        public bool Disponivel { get; set; }
        public int CodigoDoProduto { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public DateTime DataDeEntrada { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
