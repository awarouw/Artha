using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Artha.Server.Data;
using Artha.Shared.Entities;
using Artha.Shared.ViewModels;
using Artha.Server.Helpers;

namespace Artha.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixedAssetsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FixedAssetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FixedAssets
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<FixedAsset>>> GetFixedAsset()
        //{
        //    return await _context.FixedAsset.ToListAsync();
        //}

        [HttpGet]
        public async Task<ActionResult<List<FixedAsset>>> Get([FromQuery] PaginationViewModel paginationViewModel)
        {
            var queryable = _context.FixedAsset.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationViewModel.RecordsPerPage);
            return await queryable.Paginate(paginationViewModel).ToListAsync();
        }

        // GET: api/FixedAssets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FixedAsset>> GetFixedAsset(int id)
        {
            var fixedAsset = await _context.FixedAsset.FindAsync(id);

            if (fixedAsset == null)
            {
                return NotFound();
            }

            return fixedAsset;
        }

        // PUT: api/FixedAssets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutFixedAsset(FixedAsset fixedAsset)
        {
            //if (id != fixedAsset.FixedAssetID)
            //{
            //    return BadRequest();
            //}

            _context.Entry(fixedAsset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FixedAssetExists(fixedAsset.FixedAssetID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FixedAssets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FixedAsset>> PostFixedAsset(FixedAsset fixedAsset)
        {
            _context.FixedAsset.Add(fixedAsset);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFixedAsset", new { id = fixedAsset.FixedAssetID }, fixedAsset);
        }

        // DELETE: api/FixedAssets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFixedAsset(int id)
        {
            var fixedAsset = await _context.FixedAsset.FindAsync(id);
            if (fixedAsset == null)
            {
                return NotFound();
            }

            _context.FixedAsset.Remove(fixedAsset);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FixedAssetExists(int id)
        {
            return _context.FixedAsset.Any(e => e.FixedAssetID == id);
        }
    }
}
