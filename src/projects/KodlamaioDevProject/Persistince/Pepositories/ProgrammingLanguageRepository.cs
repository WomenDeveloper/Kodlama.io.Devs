using System;
using Domain.Entities;
using Core.Persistence.Pepositories;
using Persistince.Contexts;
using Core.Persistence.Repositories;
using Application.Services.Repositories;

namespace Persistince.Pepositories
{
    public class ProgrammingLanguageRepository : EfRepositoryBase<ProgrammingLanguage, BaseDbContext>, IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(BaseDbContext context) : base(context)
        {
        }
    }
}

