namespace BlazingPizza.Controllers;
using BlazingPizza.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("specials")]
[ApiController]
public class SpecialsController : ControllerBase
{
    private readonly PizzaStoreContext _context;
    public SpecialsController(PizzaStoreContext context) => _context = context;

    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _context.PizzaSpecials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}