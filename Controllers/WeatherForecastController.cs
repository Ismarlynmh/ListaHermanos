/*using HermanosApi.DAL;
using HermanosApi.Models;*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HermanosApi.Controllers;

/*[ApiController]
[Route("[controller]")]
public class HermanosController : ControllerBase
{
    private readonly ILogger<HermanosController> _logger;
    //private Contexto _contexto;

    public HermanosController(ILogger<HermanosController> logger, Contexto contexto)
    {
        _logger = logger;
    //    _contexto = contexto;
    }

    [HttpGet(Name = "GetHermanos")]
    /*public IEnumerable<Hermanos> Get()
    {
        return _contexto.Hermanos.AsNoTracking().ToList();
    }

    [HttpPost(Name = "PostHermano")]
    public async Task<ActionResult<Hermanos>> PostHermano(Hermanos hermanos)
    {

        _contexto.Hermanos.Add(hermanos);
        await _contexto.SaveChangesAsync();
        return CreatedAtAction(nameof(PostHermano), hermanos);
    }

}*/