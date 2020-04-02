using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConsultaPlacaMvc.Models;

namespace ConsultaPlacaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly Context _context;

        public VeiculosController(Context context)
        {
            _context = context;
        }

        // GET: api/Veiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetVeiculos()
        {
            return await _context.Veiculo.ToListAsync();
        }


        [HttpGet("{placa}")]
        public async Task<ActionResult<VeiculosConsulta>> GetVeiculo(string placa)
        {
            var veiculo =await _context.VeiculosConsulta.FirstAsync(x => x.Placa == placa);

            if (veiculo == null)
            {
                return NotFound();
            }

            return veiculo;
        }

        // PUT: api/Veiculos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutVeiculo(Guid id, Veiculo veiculo)
        //{
        //    if (id != veiculo.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(veiculo).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!VeiculoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Veiculos
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<Veiculo>> PostVeiculo(Veiculo veiculo)
        //{
        //    _context.Veiculos.Add(veiculo);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetVeiculo", new { id = veiculo.Id }, veiculo);
        //}

        //// DELETE: api/Veiculos/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Veiculo>> DeleteVeiculo(Guid id)
        //{
        //    var veiculo = await _context.Veiculos.FindAsync(id);
        //    if (veiculo == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Veiculos.Remove(veiculo);
        //    await _context.SaveChangesAsync();

        //    return veiculo;
        //}

        //private bool VeiculoExists(Guid id)
        //{
        //    return _context.Veiculos.Any(e => e.Id == id);
        //}
    }
}
