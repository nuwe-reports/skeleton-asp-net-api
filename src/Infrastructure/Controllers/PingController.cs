using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CleanArchitecture.Application.Ping.Queries;

namespace CleanArchitecture.Infrastructure.Controllers
{
    public class PingController : ApiControllerBase
    {
        [HttpGet("health")]
        public async Task<ActionResult<int>> Get()
        {
            return await Mediator.Send(new GetPingQuery());
        }
    }
}