using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using golink.Models;
using golink.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace golink.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISiteRepository _repo;
        public HomeController(ISiteRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index(string messageToShow, string aliasToSearch)
        {
            // It will show the popup window with message.
            if(!string.IsNullOrEmpty(messageToShow))
            {
                ViewData["messageToShow"] = messageToShow;
            }
            if(!string.IsNullOrWhiteSpace(aliasToSearch)){
                IEnumerable<Site> matchedSites = _repo.Search(aliasToSearch);
                if(matchedSites != null){
                    ViewData["isFromSearch"] = true;
                    return View(matchedSites);
                } else {
                    ViewData["messageToShow"] = $"Unable to find any site with specified alias '{aliasToSearch}'.";
                }

            }
            IEnumerable<Site> topAccessedSites = _repo.GetTopAccessedSites(10);
            return View(topAccessedSites);
        }

        [HttpPost]
        public async Task<IActionResult> AddSite([FromForm]Site site)
        {
            if(!string.IsNullOrWhiteSpace(site.Alias) && !string.IsNullOrWhiteSpace(site.Url))
            {
                // Trying to add a site to the DB.
                // If Alias exist controller returns bad request with alias and URL where it points.
                bool isAliasUnique = _repo.IsAliasUnique(site.Alias);
                if(!isAliasUnique)
                {
                    return RedirectToAction("Index", new {messageToShow=$"The Alias {site.Alias} already exist."});
                }
                
                // Trying to add and save site.
                var siteFromDb = await _repo.AddSite(site);
                bool result = await _repo.SaveAll();
                if(result)
                {
                    return RedirectToAction("Index", new {messageToShow=$"Alias '{site.Alias}' has been added to the database."});
                }else {
                    return RedirectToAction("Index", new {messageToShow="It was an Error on adding your alias to the database."});
                }
            }else{
                return RedirectToAction("Index", new {messageToShow="Please provide both, an Alias and Site URL."});
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveSite([FromForm]string alias)
        {
            Site siteFromDb = _repo.GetSite(alias);
            if(siteFromDb == null)
            {
                return RedirectToAction("Index", new{messageToShow=$"Site with '{alias}' not found in the DB."});
            }
            bool siteRemoved = await _repo.RemoveSite(alias);
            if(siteRemoved)
            {
                return RedirectToAction("Index", new{messageToShow=$"Site with '{alias}' has been removed."});
            }
            return RedirectToAction("Index", new{messageToShow=$"Error occured on deletion."});
        }
        
        // Redirect you to the alias Url if exist in DB.
        [HttpGet]
        [Route("/{alias}")]
        public IActionResult RedirectToUrl([FromRoute]string alias)
        {
            Site site = _repo.GetSite(alias);
            if(site != null)
            {
                return Redirect(site.Url);
            }
            else{
                return RedirectToAction("Index", new{messageToShow=$"Alias '{alias}' not found."});
            }
        }
    }
}
