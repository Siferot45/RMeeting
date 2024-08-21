using Microsoft.AspNetCore.Mvc;
using RMeeting.Api.DtoApi;
using RMeeting.Domain.UseCase.UseCaseForum;

namespace RMeeting.Api.Controllers
{
    [ApiController]
    [Route("forums")]
    public class ForumController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateForum(string title, 
            [FromServices] ICreatedForumUseCase useCase, CancellationToken cancellationToken)
        {
            var forum = await useCase.ExecuteAsync(title, cancellationToken);

            return Ok(forum);
        }
    }
}
