using ProdutosAPI.Models;

namespace ProdutosAPI.Service.ProdutoService
{
    public interface IProdutoInterface
    {
        Task<ServiceResponse<List<ProdutoModel>>> GetProdutos();
        Task<ServiceResponse<List<ProdutoModel>>> CreateProduto(ProdutoModel newProduto);
        Task<ServiceResponse<ProdutoModel>> GetProdutoById(int id);
        Task<ServiceResponse<List<ProdutoModel>>> UpdateProduto(ProdutoModel EditProduto);
        Task<ServiceResponse<List<ProdutoModel>>> DeleteProduto(int id);
        Task<ServiceResponse<List<ProdutoModel>>> DisponivelProduto(int id);
    }
}
