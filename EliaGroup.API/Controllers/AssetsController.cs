using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EliaGroup.API.Data;
using EliaGroup.API.Dtos.Assets;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EliaGroup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AssetsController : ControllerBase
    {
        private readonly EliaDbContext _context;
        private readonly IMapper _mapper;

        public AssetsController(EliaDbContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/values
        [HttpGet()]
        [Authorize]
        public async Task<ActionResult<IEnumerable<AssetReadOnlyDto>>> GetAssets([FromQuery]string? assetName, [FromQuery] string? fromDate, [FromQuery] string? toDate)
        {
            var query = _context.Assets.Include(q=>q.AssetType).AsQueryable();
            if (assetName != null && assetName != "undefined")
            {
                query = query.Where(q => q.Name.ToLower().Contains(assetName));
            }
            if (fromDate != null && fromDate != "undefined")
            {
                query = query.Where(q => q.EndDate >= DateTime.Parse(fromDate));
            }
            if (toDate !=null && toDate != "undefined")
            {
                query = query.Where(q => q.EndDate <= DateTime.Parse(toDate));
            }
            var assets = await query.ToListAsync();

            //var assets = await _context.Assets
            //    .Include(q=>q.AssetType)
            //    .ToListAsync();
            var assetDtos = _mapper.Map<IEnumerable<AssetReadOnlyDto>>(assets);
            return Ok(assetDtos);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetReadOnlyDto>> GetAsset(int id)
        {
            var asset = await _context.Assets
                .Include(q=>q.AssetType)
                .FirstOrDefaultAsync(q => q.Id == id);
            if (asset == null)
            {
                return NotFound();
            }
            var assetReadOnlydto = _mapper.Map<AssetReadOnlyDto>(asset);
            return Ok(assetReadOnlydto);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<AssetCreateDto>> PostAsset([FromBody]AssetCreateDto assetCreateDto)
        {
            var asset = _mapper.Map<Asset>(assetCreateDto);
            await _context.Assets.AddAsync(asset);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAsset), new { id = asset.Id }, asset);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsset(int id, [FromBody]AssetUpdateDto updateDto)
        {

            var asset = await _context.Assets.FirstOrDefaultAsync(q => q.Id == id);
            if (asset == null)
            {
                return NotFound();
            }
            _mapper.Map(updateDto, asset);
            _context.Entry(asset).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!await AssetExists(asset))
                {
                    return NotFound();
                }
            }
            return NoContent();
        }

        private async Task<bool> AssetExists(Asset asset)
        {
            return await _context.Assets.AnyAsync(q => q.Id == asset.Id);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsset(int id)
        {
            var asset = await _context.Assets.FindAsync(id);
            if (asset == null)
            {
                return NotFound();
            }
            _context.Assets.Remove(asset);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

