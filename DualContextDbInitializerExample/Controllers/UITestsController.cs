using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UIControlsExample.Models;

namespace DualContextDbInitializerExample.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/UITests")]
    public class UITestsController : ApiController
    {
        UIContext ui = new UIContext();
        // GET: api/UITests
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { ui.SampleNodes.ToString() };
        }

        // GET: api/UITests/5
        [Route("")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UITests
        [Route("")]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UITests/5
        [Route("")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UITests/5
        [Route("")]
        public void Delete(int id)
        {
        }
    }
}
