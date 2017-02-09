using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace skeletonRESTApp.Controllers
{
    public class Entity
    {
        private readonly string _name;
        private readonly string _country;
        public Entity()
        {

        }
        public Entity(string n, string c)
        {
            this._name = n;
            this._country = c;
        }
        public string Name { get { return _name; } }
        public string Country { get { return _country; } }
    }
    public class Entities
    {
        public Entity[] Objects { get; set; }
    }
    public class ValuesController : ApiController
    {
        // GET api/values
        public Entities Get()
        {
            Entity[] es = {new Entity("Alfreds Futterkiste", "Germany"), 
                              new Entity("Ana Trujillo Emparedados y helados", "Mexico")
                              };
            Entities ets = new Entities();
            ets.Objects = es;
            return ets;
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
    }
}
