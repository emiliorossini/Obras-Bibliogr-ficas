using System;
using System.Collections.Generic;
using System.Text;
using TesteConquest.Application.DTO;

namespace TesteConquest.Application.Interfaces
{
    public interface IAutorAppService : IDisposable
    {
        IEnumerable<AutorDto> GetInfo(int qt);
    }
}
