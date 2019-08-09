using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteConquest.Application.DTO;
using TesteConquest.Application.Interfaces;

namespace TesteConquest.Site.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {

        private readonly IAutorAppService _autorAppService;

        public SampleDataController(IAutorAppService autorAppService)
        {
            _autorAppService = autorAppService;
        }

        [HttpGet("[action]")]
        public IEnumerable<AutorDto> Get(int qtd)
        {
            var list = _autorAppService.GetInfo(qtd);

            return list;
        }

    }
}
