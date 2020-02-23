using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using golink.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace golink.Data
{
    public class SiteRepository : ISiteRepository
    {
        private readonly MyDbContext _context;
        public SiteRepository(MyDbContext context)
        {
            _context = context;
        }
        public async Task<Site> AddSite(Site site)
        {
            bool isAliasUnique = IsAliasUnique(site.Alias);
            if(!isAliasUnique)
            {
                return null;
            }else {
                site.Alias = site.Alias.ToLower();
                site.CreatedOn = DateTime.UtcNow;
                await _context.Sites.AddAsync(site);
                return site;
            }

        }

        public async Task<IEnumerable<Site>> GetAllSites()
        {
            return await _context.Sites.ToListAsync();
        }

        public async Task<Site> GetSiteById(int id)
        {
            Site site = await _context.Sites.FindAsync(id);
            if(site != null)
            {
                site.LastTimeAccessed = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                return site;
            }
            return site;
        }

        public Site GetSite(string alias)
        {
            if(!string.IsNullOrEmpty(alias))
            {
                alias = alias.ToLower();
                Site site = _context.Sites.Where<Site>(p => p.Alias == alias).FirstOrDefault();
                if(site != null)
                {
                    site.LastTimeAccessed = DateTime.UtcNow;
                    site.Accessed += 1;
                    _context.SaveChangesAsync();
                    return site;
                }else {
                    return null;
                }
            }else {
                return null;
            }   
        }

        public async Task<bool> SaveAll()
        {
            int result = await _context.SaveChangesAsync();
            return Convert.ToBoolean(result);
        }

        public bool IsAliasUnique(string alias)
        {
            Site site = _context.Sites.Where(p => p.Alias == alias.ToLower()).FirstOrDefault();
            bool a = site == null;
            return (site == null) ? true : false;
        }

        public IEnumerable<Site> GetTopAccessedSites(int topSitesCount)
        {
            IEnumerable<Site> topAccessedSites = _context.Sites.OrderByDescending(p => p.Accessed).Take(topSitesCount).ToList();
            return topAccessedSites;
        }

        public async Task<bool> RemoveSite(string alias)
        {
            Site siteFromDb = GetSite(alias);
            if(siteFromDb == null)
            {
                return false;
            }
            _context.Sites.Remove(siteFromDb);
            await _context.SaveChangesAsync();
            
            return true;
        }

        public IEnumerable<Site> Search(string alias)
        {
            IEnumerable<Site> matchedSites = _context.Sites.Where(p => p.Alias.StartsWith(alias)).ToList();
            if(matchedSites.Count() > 0)
            {
                return matchedSites;
            }
            return null;
        }
    }
}