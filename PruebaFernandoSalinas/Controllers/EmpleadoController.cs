using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaFernandoSalinas.Models;

namespace PruebaFernandoSalinas.Controllers
{
    public class EmpleadoController : Controller
    {

        private readonly EmpleadosContext _context;

        public EmpleadoController(EmpleadosContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            List<Empleado> lista = await _context.Empleados.ToListAsync();
            return View(lista);
        }



        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Empleado modelo)
        {
            try
            {
                Empleado empleado = new Empleado //objeto del tipo empleado
                {
                    NombreEmpleado = modelo.NombreEmpleado,
                    ApellidoEmpleado = modelo.ApellidoEmpleado,
                    EdadEmpleado = modelo.EdadEmpleado,
                    DireccionEmpleado = modelo.DireccionEmpleado,
                    NumeroTelefono = modelo.NumeroTelefono,
                    EmailEmpleado = modelo.EmailEmpleado
                };

                await _context.Empleados.AddAsync(empleado);
                await _context.SaveChangesAsync();
                ViewData["Mensaje"] = "Empleado registrado con exito";

                return View();
            }
            catch
            {
                ViewData["Error"] = "No se ha registrado el empleado";
                return View();
            }
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Empleado empleado = await _context.Empleados.FirstAsync(e => e.IdEmpleado == id);
            return View(empleado);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Empleado empleado = await _context.Empleados.FirstAsync(e => e.IdEmpleado == id);
            return View(empleado);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Empleado empleado)
        {
            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
