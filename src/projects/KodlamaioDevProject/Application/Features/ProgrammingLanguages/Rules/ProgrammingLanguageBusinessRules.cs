using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguages.Rules
{
    public class ProgrammingLanguageBusinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task ProgrammingLanguageAlreadyExists(string name)
        {
            IPaginate<ProgrammingLanguage> result = _programmingLanguageRepository.GetListAsync(programmingLanguage => programmingLanguage.Name == name).Result;
            if (result.Items.Any())
            {
                 throw new BusinessException("Brand name exists.");
            }
        }
        public async Task ProgrammingLanguageExistsWhenRequest(int id)
        {
            ProgrammingLanguage? programmingLanguage = _programmingLanguageRepository.GetAsync(pl => pl.Id == id).Result;
            if (programmingLanguage==null)
            {
                throw new BusinessException("Brand name exists.");
            }
        }
    }
}