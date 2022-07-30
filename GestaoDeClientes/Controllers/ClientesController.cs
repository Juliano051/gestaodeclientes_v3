using GestaoDeClientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeClientes.Controllers
{
    public class ClientesController : Controller
    {
        private readonly Contexto _contexto;

        public ClientesController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Clientes.ToListAsync());
        }

        
        public async Task<IActionResult> PainelClientes()
        {
            return View(await _contexto.Clientes.ToListAsync());
        }


        [HttpGet]
        public async Task<IActionResult> ListarClientes()
        {
            return View(await _contexto.Clientes.ToListAsync());
        }

        [HttpGet]
        public IActionResult NovoCliente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovoCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(cliente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(cliente);
            }
        }

        [HttpGet]
        public IActionResult AtualizarCliente(int id)
        {
            if (id != null)
            {
                Cliente cliente = _contexto.Clientes.Find(id);
                return View(cliente);
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult PerfilCliente(int? id)
        {
            if (id != null)
            {
                Cliente cliente = _contexto.Clientes.Find(id);
                return View(cliente);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarCliente(int id, Cliente cliente)
        {
            
                if (ModelState.IsValid)
                {
                    _contexto.Update(cliente);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(cliente);
           
        }

        [HttpGet]
        public IActionResult ExcluirCliente(int? id)
        {
            if (id != null)
            {
                Cliente cliente = _contexto.Clientes.Find(id);
                return View(cliente);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirCliente(int? id, Cliente cliente)
        {
            if (id != null)
            {
                _contexto.Remove(cliente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }


    }
}
