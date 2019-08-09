using System;
using System.Collections.Generic;
using System.Text;
using TesteConquest.Application.DTO;
using TesteConquest.Application.Interfaces;
using TesteConquest.Domain.Interfaces;

namespace TesteConquest.Application
{
    public class AutorAppService : IAutorAppService
    {
        private readonly IAutorService _autorService;

        public AutorAppService(IAutorService autorService)
        {
            _autorService = autorService;
        }

        public IEnumerable<AutorDto> GetInfo(int qt)
        {
            var autores = _autorService.GetInfo(qt);
            var autoresDto = new List<AutorDto>();

            foreach (var a in autores)
            {
                var autorDto = new AutorDto()
                {
                    NomeFormatado = a.NomeExibicao
                };

                autoresDto.Add(autorDto);
            }

            return autoresDto;          

        }

        public void Dispose()
        {

        }
    }
}
