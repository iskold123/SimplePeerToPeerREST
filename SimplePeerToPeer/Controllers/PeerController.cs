using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimplePeerToPeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeerController : ControllerBase
    {
        private static Dictionary<string, List<FileEndPoint>> _data = new Dictionary<string, List<FileEndPoint>>
        {


        };

        // GET: api/<PeerController>
        [HttpGet]
        [Route("api/powernap/{filename}")]
        public List<FileEndPoint> GetAll(string filename)
        {
            return _data[filename];
        }

        // GET api/<PeerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PeerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
