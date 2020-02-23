using System.Collections.Generic;
using System.Threading.Tasks;
using golink.Models;

namespace golink.Data
{
    public interface ISiteRepository
    {
        Site GetSite(string alias);
        Task<Site> GetSiteById(int id);
        // Gets top accessed sites by using Accessed property of the Site model
        // topSitesCount will return you N sites
        IEnumerable<Site> GetTopAccessedSites(int topSitesCount);
        Task<IEnumerable<Site>> GetAllSites();
        Task<Site> AddSite(Site site);
        Task<bool> SaveAll();
        bool IsAliasUnique(string alias);
        
        Task<bool> RemoveSite(string alias);
        IEnumerable<Site> Search(string alias);
    }
}