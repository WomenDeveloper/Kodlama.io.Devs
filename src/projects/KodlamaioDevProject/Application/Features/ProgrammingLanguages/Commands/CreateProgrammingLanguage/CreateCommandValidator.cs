using System;
using Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using FluentValidation;

namespace Application.Features.ProgrammingLanguages.Commands
{
    public class CreateCommandValidator : AbstractValidator<CreateProgrammingLanguageCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}

