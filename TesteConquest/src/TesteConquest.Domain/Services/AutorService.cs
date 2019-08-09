using System;
using System.Collections.Generic;
using System.Text;
using TesteConquest.Domain.Entities;
using TesteConquest.Domain.Interfaces;

namespace TesteConquest.Domain.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public IEnumerable<Autor> GetInfo(int qt)
        {
            return _autorRepository.GetInfo(qt);
        }


    }
}
