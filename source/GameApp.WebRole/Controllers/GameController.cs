using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace GameApp.WebRole.Controllers
{
    public class GameController : ApiController
    {
        // GET /api/game
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /api/game/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/game
        public void Post(string value)
        {
        }

        // PUT /api/game/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/game/5
        public void Delete(int id)
        {
        }
    }
}
