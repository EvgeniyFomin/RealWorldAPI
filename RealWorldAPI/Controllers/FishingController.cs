using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealWorldAPI.DataAccess;
using RealWorldAPI.Models.Fishing;
using RealWorldAPI.Models.ViewModels;

namespace RealWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishingController : Controller
    {
        private readonly FishingDbContext db;
        private readonly IMapper mapper;
        public FishingController(FishingDbContext context, IMapper mapper)
        {
            this.db = context;
            this.mapper = mapper;
        }

        [Route("lures")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LureViewModel>>> GetLures()
        {
            var lures = await db.Lure.ToListAsync();
            return Ok(this.mapper.Map<List<Lure>, List<LureViewModel>>(lures));
        }

        [HttpGet("lure/{id}")]
        public async Task<ActionResult<LureViewModel>> GetLureById(int id)
        {
            var lure = await this.db.Lure.FirstOrDefaultAsync(x => x.Id == id);
            if (lure == null)
                return NotFound();
            return this.mapper.Map<Lure, LureViewModel>(lure);
        }

        [HttpPost("add-lure")]
        public async Task<ActionResult> AddLure(LureViewModel lure)
        {
            if (lure == null)
                return BadRequest();
            db.Lure.Add(this.mapper.Map<LureViewModel, Lure>(lure));
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}