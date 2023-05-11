using AppServices;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidDetailController : ControllerBase
    {

        ICovidDetailServices servies;

        public CovidDetailController(ICovidDetailServices servies)
        {
            this.servies = servies;
        }

        [HttpGet]
        public ActionResult<List<CCovidDetail>> GetAll()
        {
            List<CCovidDetail> covidDetailList = servies.GetList();
            if (covidDetailList.Count == 0)
            {
                return NoContent();
            }
            return Ok(covidDetailList);
        }


        [HttpGet("{id}")]
        public ActionResult<CCovidDetail> GetById(int id)
        {
            CCovidDetail cCovid = servies.GetById(id);
            if (cCovid == null)
            {
                return NoContent();
            }
            return Ok(cCovid);
        }

        [HttpPost]
        public ActionResult<string> Create(CCovidDetail cCovidDetail)
        {

            if (cCovidDetail != null)
            {
                servies.Create(cCovidDetail);
                return Ok("Created!!!");
            }
            return NoContent();
        }
    }
}
