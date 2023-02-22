using LFIRAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace LFIRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LFIRAPIController : ControllerBase
    {


        [HttpGet]
        [Route("GetAllLFIR")]
        [RequiredScope(RequiredScopesConfigurationKey = "AzureAd.Scopes.User")]
        public IActionResult GetNames()
        {
            return Ok(Data.LFIRList);
        }

        [HttpPost]
        [Route("PostLFIR")]
        [RequiredScope(RequiredScopesConfigurationKey = "AzureAd.Scopes.Admin")]
        public IActionResult PostName([FromBody]LocalFundingInitiativeRequestModel localFundingInitiativeRequestModel)
        {
            Data.LFIRList.Add(localFundingInitiativeRequestModel); 
            return Ok(Data.LFIRList);
        }

    }
}
