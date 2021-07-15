using Logic.Contracts;

using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

using Web.Models;

namespace Web.Controllers
{
    [Route("api/communities")]
    [ApiController]
    public class CommunitiesController : ControllerBase
    {
        private readonly ICommunitieLogic communitieLogic;

        public CommunitiesController(ICommunitieLogic communitieLogic)
        {
            this.communitieLogic = communitieLogic;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await communitieLogic.GetCommunitieById(id);

            if(result == null)
            {
                return NotFound();
            }

            var communitie = new CommunitieDto
            {
                Id = result.Id,
                Name = result.Name
            };

            return Ok(communitie);
        }
    }
}
