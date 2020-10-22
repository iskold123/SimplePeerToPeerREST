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
    [Route("api/powernap/")]
    [ApiController]
    public class PeerController : ControllerBase
    {
        private static Dictionary<string, List<FileEndPoint>> _data = new Dictionary<string, List<FileEndPoint>>
        {

        };

        private static void InsertIntoDictionary(Dictionary<string, List<FileEndPoint>> _data, string filename,
            FileEndPoint fep)
        {
            if (_data.ContainsKey(filename))
            {
                List<FileEndPoint> listOfFep = _data[filename];
                listOfFep.Add(fep);
            }
            else
            {
                List<FileEndPoint> listOfFep = new List<FileEndPoint>();
                listOfFep.Add(fep);
                _data.Add(filename,listOfFep);
            }
        }

        // GET: api/<PeerController>
        [HttpGet]
        [Route("{filename}")]
        public List<FileEndPoint> GetAll(string filename)
        {
            return _data[filename];
        }

        // POST api/<PeerController>
        [HttpPost]
        //public void Register([FromBody] string filename)
        //{
        //    _data.Add(filename);
        //}

        // PUT api/<PeerController>/5
        [HttpPut("{id}")]
        public void Deregister(int id, [FromBody] string filename)
        {



        }
    }
}
