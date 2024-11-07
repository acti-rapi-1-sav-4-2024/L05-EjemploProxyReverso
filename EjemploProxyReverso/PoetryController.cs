using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploProxyReverso
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoetryController : ControllerBase
    {
        private IPoetryService _service;

        public PoetryController(IPoetryService service)
        {
            _service = service;
        }
        // GET: api/<PoetryController>
        [HttpGet]
        public async Task<string> Get()
        {
            return await _service.GetAuthorsAsync();
        }
    }
}
