using EtecShopAPI.Data;
using EtecShopAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EtecShopAPI.Controllers;

    [ApiController]
    [Route("api/produtos")]
    public class ProdutosController(AppDbContext db) : ControllerBase
    {
        
    }
