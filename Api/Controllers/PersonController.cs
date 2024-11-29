using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController(IMediator _mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<PersonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel p)
        {
            var model = new InsertPersonCommand(p.FirstName, p.LastName);

            return await _mediator.Send(model);
        }
    }
}