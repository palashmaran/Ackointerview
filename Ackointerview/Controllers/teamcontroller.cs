using AckoTeamEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ackointerview.Controllers
{
    public class teamcontroller : ApiController
    {
        private ackointerviewEntities dbentity;

        public teamcontroller()
        {
            this.dbentity = new ackointerviewEntities();
        }
        public teamcontroller(ackointerviewEntities dbentity)
        {
            this.dbentity = dbentity;
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody] Team team)
        {
            //Teamview teamobj = new Teamview(team.ID, team.name);
            List<Devloper> devobj = (List<Devloper>)team.Devlopers;
            
            
            dbentity.Teams.Add(team);
            dbentity.SaveChanges();

            foreach (var dev in devobj)
            {
                dbentity.Devlopers.Add(dev);
                dbentity.SaveChanges();
            }

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}