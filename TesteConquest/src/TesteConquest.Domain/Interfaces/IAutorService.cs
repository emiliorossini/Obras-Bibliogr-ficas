using System;
using System.Collections.Generic;
using System.Text;
using TesteConquest.Domain.Entities;

namespace TesteConquest.Domain.Interfaces
{
    public interface IAutorService
    {
        IEnumerable<Autor> GetInfo(int qt);
    }
}
