using System.Collections.Generic;
using System.Threading.Tasks;
using golink.Data;
using golink.Models;
using Microsoft.AspNetCore.Mvc;

namespace golink.Controllers
{
    [Route("api/[controller]")]
    public class SiteController: Controller
    {
        private readonly ISiteRepository _repo;
        public SiteController(ISiteRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        [Route("AddSite")]
        public async Task<IActionResult> AddSite([FromBody]Site site)
        {
            // Trying to add a site to the DB.
            // If Alias exist controller returns bad request with alias.
            Site siteFromDb =  await _repo.AddSite(site);
            if(siteFromDb == null)
            {
                return BadRequest($"The Alias {site.Alias} already exist.");
            }
            
            // Trying to save site.
            bool result = await _repo.SaveAll();
            if(result)
            {
                return Ok(site);
            }
            else {
                return StatusCode(500, "Error occured on saving site to the DB.");
            }
    }
        [HttpPost]
        [Route("RemoveSite/{alias}")]
        public async Task<IActionResult> RemoveSite([FromRoute]string alias)
        {
            Site siteFromDb = _repo.GetSite(alias);
            if(siteFromDb == null)
            {
                return BadRequest($"Site with '{alias}' not found in the DB.");
            }
            bool siteRemoved = await _repo.RemoveSite(alias);
            if(siteRemoved)
            {
                return Ok($"Site with the alias '{alias}' has been removed.");
            }
            return StatusCode(500, $"Error occured on removing site with alias '{alias}'.");
        }

        [HttpGet]
        [Route("GetSiteById")]
        // https://localhost:[port]/api/site/GetSiteById?id=1
        public async Task<IActionResult> GetSiteById([FromQuery]int id)
        {
            if(id != 0)
            {
                Site site = await _repo.GetSiteById(id);
                return Ok(site);
            }
            else {
                return BadRequest("Please specify site id as a query parameter (ex: ?Id=1).");
            }

        }
        
        [HttpGet]
        [Route("GetAllSites")]
        // https://localhost:[port]/api/site/GetAllSites
        public async Task<IActionResult> GetAllSites()
        {
            IEnumerable<Site> allSites = await _repo.GetAllSites();
            if(allSites != null)
            {
                return Ok(allSites);
            }else {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("GetTopAccessedSites/{number}")]
        // https://localhost:[port]/api/site/GetTopAccessedSites/2
        public IActionResult GetTopAccessedSites([FromRoute]int number)
        {
            if(number > 1)
            {
                IEnumerable<Site> topAccessedSites = _repo.GetTopAccessedSites(number);
                return Ok(topAccessedSites);
            }
            else {
                return BadRequest("You should specify at least two most visited sites to get.");
            }

        }

        [HttpGet]
        [Route("GetSite/{alias}")]
        // "https://localhost:[port]/api/Site/TestAlias"
        public IActionResult GetSite([FromRoute]string alias)
        {
            if(!string.IsNullOrEmpty(alias))
            {
                Site site = _repo.GetSite(alias);
                if(site != null)
                {
                    return Ok(site);
                }
                else{
                    return NotFound();
                }
            }
            else {
                return BadRequest("Please specify site alias.");
            }
        }
    }
}