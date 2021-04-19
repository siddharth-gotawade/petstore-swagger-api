using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Petstore_Swagger_Api.Controllers
{
    public class PetstoreController : Controller
    {
        // POST api/pet/values
        public void Post([FromBody]string value)
        {
        }

        //POST api/pet/{petId}/uploadImage
        public void Post(int petId, [FromBody]string value)
        {
        }

        // PUT api/pet/values/5
        public void Put(int petId, [FromBody]string value)
        {
        }


        // GET api/pet/status/5
        public string Get(string status)
        {
            return "value";
        }

        // GET api/pet/values/{petid}
        public string Get(int? petId)
        {
            return "value";
        }

        // DELETE api/pet/values/{petid}
        public void Delete(int? petId)
        {
        }

    }
}