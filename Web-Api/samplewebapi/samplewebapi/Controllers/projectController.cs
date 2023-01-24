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
    public class projectController : ApiController
    {
        public readonly iProject iproject;
        public projectController(iProject iProject)
        {
            this.iproject = iProject;
        }
        [Route("api/project/insertemp")]
        [HttpPost]
        public  HttpResponseMessage insertEmpDetails(projectModel pro)
        {
            
            var ret = iproject.insertemp(pro);
            return Request.CreateResponse(HttpStatusCode.OK, ret);
          
        }
        [Route("api/sample/joins")]
        [HttpGet]
        public IEnumerable<projectModel> Getjoins()
        {


            return iproject.Getjoins().ToList();

        }

        /* [Route("api/sample/GetAllEmpInfo")]
         [HttpPost]
         public IHttpActionResult GetGroupby()
         {
             var ret = iproject.GetGroupby();
             if (ret.Count == 0)
             {
                 return NotFound();
             }
             return Ok(ret);
         }*/


    }
}
