using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EliaGroup.API.Data;
using EliaGroup.API.Dtos.Assets;
using EliaGroup.API.Dtos.AssetTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EliaGroup.API.Controllers
{
    [Route("api/[controller]")]
    public class AssetTypesController:ControllerBase
	{
        private readonly EliaDbContext _context;
        private readonly IMapper _mapper;

        public AssetTypesController(EliaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetTypeReadOnlyDto>>> GetAssets()
        {
            var assetTypes = await _context.AssetTypes.ToListAsync();
            var assetTypeDtos = _mapper.Map<IEnumerable<AssetTypeReadOnlyDto>>(assetTypes);
            return Ok(assetTypeDtos);
        }
    }
}

