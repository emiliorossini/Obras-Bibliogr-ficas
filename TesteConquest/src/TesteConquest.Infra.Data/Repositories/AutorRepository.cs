using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteConquest.Domain.Entities;
using TesteConquest.Domain.Interfaces;
using TesteConquest.Infra.Data.Context;

namespace TesteConquest.Infra.Data.Repositories
{
    public class AutorRepository : RepositoryBase<Autor>, IAutorRepository
    {
        public AutorRepository(ConquestContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Autor> GetInfo(int qt)
        {
            return DbSet.Take(qt).ToList();
        }
    }
   
}
