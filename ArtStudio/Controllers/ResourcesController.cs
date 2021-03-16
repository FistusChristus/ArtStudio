using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtStudio.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "Authorized")]
    [ApiController]
    public class ResourcesController: ControllerBase
    {
    }

}
