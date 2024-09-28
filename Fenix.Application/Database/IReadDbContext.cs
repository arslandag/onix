using Fenix.Application.Dtos;

namespace Fenix.Application.Database;

public interface IReadDbContext
{
    IQueryable<WebSiteDto> WebSites { get; }
    IQueryable<BlockDto> Blocks { get; }
}