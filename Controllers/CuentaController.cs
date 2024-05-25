using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sillicon.Models;
using sillicon.Data;

public class CuentaController : Controller
{
    private readonly ILogger<CuentaController> _logger;
    private readonly ApplicationDbContext _context;


    public CuentaController(ILogger<CuentaController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    // GET: Cuenta/Registro
    /*public ActionResult Registro()
    {
        return View();
    }   */
    public IActionResult Index()
    {
        return View();
    }

    // POST: Cuenta/Registro
    [HttpPost]
    public ActionResult Registro(Cuenta objcuenta)
    {
        _logger.LogDebug("Ingreso a Enviar Mensaje");

        //Se registran los datos del objeto a la base datos
        _context.Add(objcuenta);
        _context.SaveChanges();

        ViewData["Message"] = "Se registro el contacto";
        return View("Index");
    }

    // GET: Cuenta/RegistroExitoso
    public ActionResult RegistroExitoso()
    {
        // Muestra un mensaje de éxito después de registrar la cuenta.
        ViewBag.Mensaje = TempData["Mensaje"];
        return View();
    }
}