using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.SharedObjects;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Entities;

public class WebSite : Shared.Entity<WebSiteId>
{
    private WebSite(
        WebSiteId id,
        Url url,
        ShowStatus showStatus,
        Configuration configuration) : base(id)
    {
        Url = url;
        ShowStatus = showStatus;
        Configuration = configuration;
    }
    
    public Url Url { get; private set; }
    public ShowStatus ShowStatus { get; private set; }
    public Configuration Configuration { get; private set; }

    public static Result<WebSite> Create(
        WebSiteId id,
        Url url,
        ShowStatus showStatus,
        Configuration configuration)
    {
        return new WebSite(
            id,
            url,
            showStatus,
            configuration);
    }
}