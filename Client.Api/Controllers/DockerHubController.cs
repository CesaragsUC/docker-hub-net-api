using Microsoft.AspNetCore.Mvc;
using ObterRepositorioDockerHub.Services;

namespace ObterRepositorioDockerHub.Controllers
{
    [ApiController]
    [Route("api/docker-registry")]
    public class DockerHubController(IDockerHubService service) : ControllerBase
    {

        [HttpGet]
        [Route("with-tags/{imageName}")]
        public async Task<IActionResult> WithTags(string imageName)
        {
            var result = await service.GetRepositoriesWithTagAsync(imageName);
            return Ok(result);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> All()
        {
            var result = await service.GetRepositoriesAsync();
            return Ok(result);
        }
    }
}
