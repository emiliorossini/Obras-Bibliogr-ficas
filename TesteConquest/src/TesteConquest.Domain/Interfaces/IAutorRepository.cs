using System;
using System.Collections.Generic;
using System.Text;
using TesteConquest.Domain.Entities;

namespace TesteConquest.Domain.Interfaces
{
    public interface IAutorRepository : IRepositoryBase<Autor>
    {
        IEnumerable<Autor> GetInfo(int qt);
    }
}
