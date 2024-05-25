using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sillicon.Data;
using sillicon.Models;
using Microsoft.EntityFrameworkCore;

namespace sillicon.Controllers.Rest
{
    [ApiController]
    [Route("api/Usuario")]
    public class ProductoApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductoApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Cuenta>>> List()
        {
            var productos = await _context.DataCuenta.ToListAsync();
             if(productos == null)
                return NotFound();
            return Ok(productos);
        }

    }
}