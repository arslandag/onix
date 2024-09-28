using CSharpFunctionalExtensions;
using Fenix.Application.Dtos;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.WebSites;
using Fenix.Infrastructure.DateBase.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Fenix.Infrastructure.DateBase.Repositories;

public class WebSiteRepository
{
    private readonly WriteDbContext _dbContext;

    public WebSiteRepository(WriteDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Result<WebSite, Error>> GetById(
        WebSiteId webSiteId, CancellationToken cancellationToken = default)
    {
        var website = _dbContext.WebSites
            .Include(w => w.Blocks)
            .ThenInclude(b => b.BackgroundPhoto)
            .Include(w => w.Blocks)
            .ThenInclude(b => b.Products)
            .Include(w => w.Blocks)
            .ThenInclude(b => b.Locations)
            .Include(w => w.Blocks)
            .ThenInclude(b => b.Photos)
            .FirstOrDefaultAsync(w => w.Id == webSiteId);
        
    }
}