using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammingLanguagesController : BaseController
    {

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody]CreateProgrammingLanguageCommand createdProgrammingLanguageCommand)
        {

            CreatedProgrammingLanguageDto result = await Mediator.Send(createdProgrammingLanguageCommand);
            return Created("", result);
        }
    }
}

