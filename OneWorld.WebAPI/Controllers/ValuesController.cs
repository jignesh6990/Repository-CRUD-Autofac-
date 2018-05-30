using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OneWorld.Service;
using OneWorld.Model;
namespace OneWorld.WebAPI.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        ISupplierService _service;
        public ValuesController(ISupplierService service)
        {
            _service = service;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        [ActionName(name: "AllSupplier")]
        public IEnumerable<Supplier> GetAllSupplier()
        {
            IEnumerable<Supplier> listData = _service.GetAll();

            if (listData.Count() > 0)
            {
                return listData;
            }
            return listData;
            //return _service.GetAllSupplier(); 
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpPost]
        public HttpResponseMessage AddSupplier([FromBody] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                var result = _service.AddSupplier(supplier);
                return Request.CreateResponse(HttpStatusCode.OK,result);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        public HttpResponseMessage UpdateSupplier([FromBody] Supplier supplier)
        {
            if(ModelState.IsValid)
            {
                if(supplier.Id>0)
                {
                    bool isSuccess = _service.UpdateSupplier(supplier);
                    if(isSuccess)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.OK, "Id must be greater than 0");
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest,"Id must be greater than 0");
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }
    }
}
