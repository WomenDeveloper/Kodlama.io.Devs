using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.ProgrammingLanguages.Commands.CreateProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Dtos;
using Application.Features.ProgrammingLanguages.Models;
using Application.Features.ProgrammingLanguages.Queries.GetByIdProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Queries.GetListProgrammingLanguage;
using Core.Application.Requests;
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

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromBody] PageRequest  pageRequest)
        {
            GetListProgrammingLanguageQuery getListProgrammingLanguageQuery = new() { PageRequest = pageRequest };

            ProgrammingLanguageListModel result = await Mediator.Send(getListProgrammingLanguageQuery);

            return Ok(result);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromBody] GetByIdProgrammingLanguageQuery getByIdprogrammingLanguageQuery)
        {
            ProgrammingLanguageGetByIdDto languageGetByIdDto =  await Mediator.Send(getByIdprogrammingLanguageQuery);

            return Ok(languageGetByIdDto);
        }

        [HttpDelete("delete/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProgrammingLanguageCommand deleteProgrammingLanguageCommand)
        {
            DeletedProgrammingLanguageDto result = await Mediator.Send(deleteProgrammingLanguageCommand);
            return Ok(result);
        }
        [HttpPut("update/{Id}")]
        public async Task<IActionResult> Update([FromRoute] UpdateProgrammingLanguageCommand updateProgrammingLanguageCommand)
        {
            UpdatedProgrammingLanguageDto result = await Mediator.Send(updateProgrammingLanguageCommand);
            return Ok(result);
        }

    }
}

