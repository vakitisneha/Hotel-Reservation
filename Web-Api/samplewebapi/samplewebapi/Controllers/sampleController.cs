using samplewebapi.Models;
using samplewebapi.rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace samplewebapi.Controllers
{
    public class sampleController : ApiController
    {
        public readonly IEMPdetails Iemprep;
        public sampleController(IEMPdetails iemprep)
        {
            this.Iemprep = iemprep;
        }
        [Route("api/sample/GetEmpInfo")]
        [HttpGet]
        public List<EmpModel> GetAllEmpdetail()
        {
            var ret = Iemprep.GetAllEmpDetails();
            return ret;
        }
        [Route("api/sample/GetEmpinfo/{rollno}")]
        [HttpGet]
        public IHttpActionResult GetAllEmpdata(int rollno)
        {
            var ret = Iemprep.GetEmpDetail(rollno);
            return Ok(ret);
        }

        [Route("api/sample/GetAllEmpInfo")]
        [HttpGet]
        public IHttpActionResult GetAllEmpDetails()
        {
            var ret = Iemprep.GetAllEmpDetails();
            if (ret.Count == 0)
            {
                return NotFound();
            }
            return Ok(ret);
        }
        //for update all
         [Route("api/sample/update")]
          [HttpPut]
          public IHttpActionResult updateEmp(EmpModel empu)
          {
              if (!ModelState.IsValid)
                  return BadRequest("not a valid model");
              var ret = Iemprep.updateEmpDetail(empu);
              if (ret == null)
              {
                  return NotFound();
              }
              return Ok();
          }
        //bulk update
       /* [Route("api/sample/update")]
        [HttpPut]
        public IHttpActionResult updateEmpDetail()
        {
           
            var ret = Iemprep.updateEmpDetail();
           
            return Ok(ret);
        }
       */
        [Route("api/sample/insert")]
        [HttpPost]


        public IHttpActionResult insertEmpDetails(EmpModel empi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("not a valid model");

            }
            var ret = Iemprep.insertEmpDetails(empi);
            if (ret == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [Route("api/sample/bulkinsert")]
        [HttpPost]
        public IHttpActionResult bulkinsert(List<EmpModel> empi)
        {
            var ret = Iemprep.bulkinsert(empi);
            return Ok(ret);

        }
        [Route("api/sample/bulkdel")]
        [HttpDelete]
        public IHttpActionResult bulkdel()
        {
            var ret = Iemprep.bulkdel();
                return Ok(ret);
        }
        /*  public HttpResponseMessage insertEmpDetails(EmpModel empi)
          {
              // if (!ModelState.IsValid)
              //return BadRequest("not a valid model");
              var ret = Iemprep.insertEmpDetails(empi);
              return Request.CreateResponse(HttpStatusCode.OK, ret);
              //if(ret==null)

          }
        */

        [Route("api/sample/delete/{rollno}")]
        [HttpDelete]
        public HttpResponseMessage deleteEmpdetails(int rollno)

        {
            var ret = Iemprep.deleteEmpdetails(rollno);
            return Request.CreateResponse(HttpStatusCode.OK, ret);
        }
    }

}


    /*
        [Route("api/sample/GetEmpInfo")]
        [HttpGet]
        public List<EmpModel> GetAllEmpdetail()
        {
            var ret=Iemprep.GetAllEmpDetails();
            return ret;
        }*/

    /*
    [Route("api/sample/GetEmpinfo/{id}")]
        [HttpGet]
        public EmpModel GetAllEmpdata(int id)
        {
            var ret = Iemprep.GetEmpDetail(id);
            return ret;
        }
        [Route("api/sample/insert")]
        [HttpPost]
       public string InsertEmpDetails([FromBody]int x)
        {
            Console.WriteLine(x);
            return "updated";
        }
        [Route("api/sample/ABC")]
        [HttpPost]

        public IHttpActionResult ABC([FromBody] EmpModel EmpModelId)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            return BadRequest(ModelState);
        }*/



