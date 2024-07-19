using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Models;
using ProdutosAPI.Service.ProdutoService;

namespace ProdutosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoInterface _produtoInterface;

        public ProdutoController(IProdutoInterface produtoInterface)
        {
            _produtoInterface = produtoInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> GetProdutos()
        {
            return Ok(await _produtoInterface.GetProdutos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<ProdutoModel>>> GetProdutoById(int id)
        {
            ServiceResponse<ProdutoModel> serviceResponse = await _produtoInterface.GetProdutoById(id);
            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> CreateProduto(ProdutoModel newProduto)
        {
            return Ok(await _produtoInterface.CreateProduto(newProduto));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> UpdateProduto(ProdutoModel editProduto)
        {
            ServiceResponse<List<ProdutoModel>> serviceResponse = await _produtoInterface.UpdateProduto(editProduto);
            return Ok(serviceResponse);
        }

        [HttpPut("disponivelProduto")]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> DisponivelProduto(int id)
        {
            ServiceResponse<List<ProdutoModel>> serviceResponse = await _produtoInterface.DisponivelProduto(id);
            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> DeleteProduto(int id)
        {
            ServiceResponse<List<ProdutoModel>> serviceResponse = await _produtoInterface.DeleteProduto(id);
            return Ok(serviceResponse);
        }
    }
}
