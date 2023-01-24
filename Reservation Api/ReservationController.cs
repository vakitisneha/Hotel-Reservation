using samplewebapi.Models;
using samplewebapi.rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace samplewebapi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReservationController : ApiController
    {
        public readonly IReservation Ireservation;
            public ReservationController(IReservation ireservation)
        {
            this.Ireservation = ireservation;
        }
        [Route("api/Reservation/GetallDetails")]
        [HttpGet]
        public List<ReservationModel> GetallDetails()
        {
            var ret = Ireservation.GetallDetails();
            return ret;
        }
        [Route("api/Reservation/GetDetailsbyid/{Slno}")]
        [HttpGet]
        public ReservationModel GetDetailsbyid(int Slno)
        {
            var ret = Ireservation.GetDetailsbyid(Slno);
            return ret;
        }
        [Route("api/Reservation/insert")]
        [HttpPost]
        public IHttpActionResult insertDetails(ReservationModel i)
        {
          
            var ret = Ireservation.insertdetails(i);
            return Ok(ret);
        }
        [Route("api/Reservation/update")]
        [HttpPut]
        public IHttpActionResult updatedetails(ReservationModel u)
        {
           // if (ModelState.IsValid)
            //{
              //  return BadRequest("not a valid state");
            //}
            var ret = Ireservation.updatedetails(u);
            if (ret == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [Route("api/Reservation/delete/{Slno}")]
        [HttpDelete]
        public HttpResponseMessage DeleteDetails(int Slno)
        {
            var ret = Ireservation.DeleteDetails(Slno);
    
            return Request.CreateResponse(HttpStatusCode.OK, ret);
        }

        [Route("api/Reservation/getMaster")]
        [HttpGet]
        public List<ReservationModel> getMaster()
        {
            var ret = Ireservation.getMaster();
            return ret;
        }

    }
}

