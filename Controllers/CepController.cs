using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using labassincnetcore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace labassincnetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        // GET: api/Cep
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cep/5
        [HttpGet("{IdCep}", Name = "Get")]
        public async Task<string> GetAsync(string IdCep)
        {
            HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.GetAsync($"https://viacep.com.br/ws/{IdCep}/json/");

            string responseBodyAsText = "";
            if (response.IsSuccessStatusCode)
            {
                responseBodyAsText = await response.Content.ReadAsStringAsync();
            }

            return responseBodyAsText;
        }

        // POST: api/Cep
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cep/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
