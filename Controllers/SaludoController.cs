using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HolaMvc.Models;

namespace HolaMvc.Controllers;

public class SaludoController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new Persona());
    }

    [HttpPost]
    public IActionResult Index(Persona persona)
    {
        if (!ModelState.IsValid)
        {
            return View(persona);
        }
        
        return View("Resultado", persona);
    }
}