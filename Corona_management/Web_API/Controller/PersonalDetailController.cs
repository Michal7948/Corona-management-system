using AppServices;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailController : ControllerBase
    {
        IPersonalDetailServices servies;

        public PersonalDetailController(IPersonalDetailServices servies)
        {
            this.servies = servies;
        }

        [HttpGet]
        public ActionResult<List<CPersonalDetail>> GetAll()
        {
            List<CPersonalDetail> personalDetailList = servies.GetList();
            if (personalDetailList.Count==0)
            {
                return NoContent();
            }
            return Ok(personalDetailList);
        }


        [HttpGet("{id}")]
        public ActionResult<CPersonalDetail> GetById(int id)
        {
            CPersonalDetail cPersonal = servies.GetById(id);
            if (cPersonal==null)
            {
                return NoContent();
            }
            return Ok(cPersonal);
        }


        [HttpPost]
        public ActionResult<string> Create([FromBody] CPersonalDetail cPersonalDetail)
        {

            if (cPersonalDetail != null)
            {
                servies.Create(cPersonalDetail);
                return Ok("Created!!!");
            }
            return NoContent();
            //return NotFound();
        }



        //public async Task<IActionResult> Create([FromBody] CPersonalDetail cPersonalDetail)
        //{

        //    KnownUser user1 = context.KnownUsers.FirstOrDefault(e => e.Email == email && e.Password == password);
        //    if (user1 == null)
        //        return NotFound();
        //    if (user1.Email == email)
        //    {
        //        return Created("הסיסמא שהוקשה שגויה", user1);

        //    }
        //    return Conflict();
        //}



        //[HttpPatch]
        //[Route("api/infected/{id}")]
        //public IActionResult UpdateInfected(int id, [FromBody] InfectedDTO infectedDTO)
        //{
        //    if (infectedDTO == null || id != infectedDTO.Id)
        //    {
        //        return BadRequest();
        //    }

        //    // כאן ניתן להכניס לוגיקה נוספת לטיפול בבקשה

        //    var infected = _context.Infected.FirstOrDefault(i => i.Id == id);
        //    if (infected == null)
        //    {
        //        return NotFound();
        //    }

        //    infected.Lat = infectedDTO.Lat;
        //    infected.Lon = infectedDTO.Lon;
        //    infected.Date = infectedDTO.Date;
        //    infected.RecoveryDate = infectedDTO.RecoveryDate;
        //    infected.PeopleToUpdate = infectedDTO.PeopleToUpdate;

        //    _context.Infected.Update(infected);
        //    _context.SaveChanges();

        //    return StatusCode(201);
        //}

    }
}
