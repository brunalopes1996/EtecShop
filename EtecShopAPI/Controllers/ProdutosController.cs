using EtecShopAPI.Data;
using EtecShopAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EtecShopAPI.Controllers;

[ApiController]
[Route("api/produtos")]
public class ProdutosController(AppDbContext db) : ControllerBase
{  
    private readonly AppDbContext _db = db;

    [HttpGet]
    [ProducesResponseType(200)]
    public async Task<IActionResult> Get()
    {
        List<Produto> produtos = await _db.Produtos.Include(p => p.Categoria).ToListAsync();
        return Ok(produtos);
    }

}
