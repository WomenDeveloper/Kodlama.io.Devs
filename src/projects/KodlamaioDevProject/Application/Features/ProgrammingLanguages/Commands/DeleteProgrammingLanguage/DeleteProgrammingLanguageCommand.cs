using Application.Features.ProgrammingLanguages.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage
{
    public class DeleteProgrammingLanguageCommand : IRequest<DeletedProgrammingLanguageDto>
    {
        public int Id { get; set; }
        public class DeleteProgrammingLanguageCommandHandler : IRequestHandler<DeleteProgrammingLanguageCommand,DeletedProgrammingLanguageDto>
        {
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
            private readonly IMapper _mapper;


            public DeleteProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
            {
                _programmingLanguageRepository = programmingLanguageRepository;
                _mapper = mapper;
            }


            public async Task<DeletedProgrammingLanguageDto> Handle(DeleteProgrammingLanguageCommand deleteProgrammingLanguageCommand, CancellationToken cancellationToken)
            {
                ProgrammingLanguage mappedLanguage = _mapper.Map<ProgrammingLanguage>(deleteProgrammingLanguageCommand);
                ProgrammingLanguage deletedLanguage = await _programmingLanguageRepository.DeleteAsync(mappedLanguage);
                DeletedProgrammingLanguageDto deletedLanguageDto = _mapper.Map<DeletedProgrammingLanguageDto>(deletedLanguage);
                return deletedLanguageDto;
            }
        }
    }
}

