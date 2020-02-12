using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankSystem.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using DatingApp.API.Data;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
  // [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class ClientsController : ControllerBase
  {
    private readonly DataContext _context;
    public ClientsController(DataContext context)
    {
      _context = context;
    }

    // GET api/clients
    // [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> GetClients()
    {
      var clients = await  _context.Clients.ToListAsync();

      return Ok(clients);
    }

    // GET api/clients/5
    // [AllowAnonymous]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetClient(int id)
    {
      var client = await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);

      return Ok(client);
    }

    // POST api/clients
    [HttpPost]
    public void Post([FromBody] string client)
    {
    }

    // PUT api/clients/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string client)
    {
    }

    // DELETE api/clients/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}