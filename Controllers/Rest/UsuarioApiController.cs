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
    public class UsuarioApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsuarioApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Cuenta>>> List()
        {
            var cuentas = await _context.DataCuenta.ToListAsync();
             if(cuentas == null)
                return NotFound();
            return Ok(cuentas);
        }

    }
}