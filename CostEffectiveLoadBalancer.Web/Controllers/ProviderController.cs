namespace CostEffectiveLoadBalancer.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using CostEffectiveLoadBalancer.Web.Models;
    using Dal;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ProviderController : Controller
    {
        public ActionResult<IEnumerable<ProviderViewModel>> GetAll(
            [FromServices] CostEffectiveLoadBalancerContext dbContext,
            [FromServices] IMapper mapper)
        {
            return Ok(dbContext.Providers.Select(x => mapper.Map<ProviderViewModel>(x)).ToAsyncEnumerable());
        }
    }
}