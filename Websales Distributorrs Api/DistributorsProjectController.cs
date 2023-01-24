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
    public class DistributorsProjectController : ApiController
    {
        public readonly IDistributorsProject IdistributorsProject;
        public DistributorsProjectController(IDistributorsProject idistributors)
        {
            this.IdistributorsProject = idistributors;
        }
        [Route("api/DistributorsProject/GetallDetails")]
        [HttpGet]
        public List<DistributorsProjectModel> GetallDetails()
        {
            var ret = IdistributorsProject.GetallDetails();
            return ret;
        }
       [Route("api/DistributorsProject/insert")]
       [HttpPost]
        public HttpResponseMessage insertdetails(DistributorsProjectModel i)
        {
            var ret = IdistributorsProject.insertdetails(i);
            return Request.CreateResponse(HttpStatusCode.OK, ret);
        }
        [Route("api/DistributorsProject/GetaddressDetails")]
        [HttpGet]
        public List<DistributorsProjectModel> GetaddressDetails()
        {
            var ret = IdistributorsProject.GetaddressDetails();
            return ret;
        }
        [Route("api/DistributorsProject/DeleteaddressDetails/{MobileNumber}")]
        [HttpDelete]
        
        public HttpResponseMessage DeleteadressDetails(int MobileNumber)
        {
            var ret = IdistributorsProject.DeleteaddressDetails(MobileNumber);

            return Request.CreateResponse(HttpStatusCode.OK, ret);
        }

        [Route("api/DistributorsProject/insertpayment")]
        [HttpPost]
        public HttpResponseMessage insertpaymentdetails(DistributorsProjectModel i)
        {

            var ret = IdistributorsProject.insertpaymentdetails(i);
            return Request.CreateResponse(HttpStatusCode.OK, ret);

        }
        [Route("api/DistributorsProject/delete/{price}")]
        [HttpDelete]
        public HttpResponseMessage DeleteDetails(int price)
        {
            var ret = IdistributorsProject.DeleteDetails(price);

            return Request.CreateResponse(HttpStatusCode.OK, ret);
        }
        [Route("api/DistributorsProject/insertemp")]
        [HttpPost]
        public HttpResponseMessage insertEmpDetails(RegistrationModel pro)
        {

            var ret = IdistributorsProject.insertemp(pro);
            return Request.CreateResponse(HttpStatusCode.OK, ret);

        }

    }
}

//[Route("api/DistributorsProject/joins")]
//[HttpGet]
//public IEnumerable<DistributorsProjectModel> Getjoins()
//{


//    return IdistributorsProject.Getjoins().ToList();



//}
