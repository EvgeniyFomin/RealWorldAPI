//using System.Collections.Generic;
//using System.Threading.Tasks;
//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using RealWorldAPI.Controllers.Resources;
//using RealWorldAPI.DataAccess;

//namespace RealWorldAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CarController : Controller
//    {
//        private readonly FishingDbContext db;
//        private readonly IMapper mapper;

//        public CarController(FishingDbContext context, IMapper mapper)
//        {
//            this.db = context;
//            this.mapper = mapper;
//        }

//        [Route("car")]
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<CarViewModel>>> GetLures()
//        {
//            var lures = await db.Cars.Include(m => m.Contact).Include(f => f.Features).ToListAsync();
//            return mapper.Map<List<CarModel>, List<CarViewModel>>(cars);
//        }


//        //[HttpPost]
//        //public async Task<ActionResult<CarViewModel>> Post(CarViewModel car)
//        //{
//        //    if (car == null)
//        //    {
//        //        return BadRequest();
//        //    }
//        //    db.Cars.Add(mapper.Map<CarViewModel, Car>(car));
//        //    await db.SaveChangesAsync();
//        //    return Ok(car);
//        //}
//        //[Route("car/{id}")]
//        //[HttpGet]
//        //public async Task<ActionResult<CarViewModel>> GetById(int id)
//        //{
//        //    var car = await db.Cars.FirstOrDefaultAsync(c => c.Id == id);
//        //    if (car == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return Ok(car);
//        //}
//    }
//}