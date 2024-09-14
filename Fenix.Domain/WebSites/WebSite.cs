using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;

namespace Fenix.Domain.WebSites;

public class WebSite : Entity<WebSiteId>
{
    private WebSite( 
        WebSiteId id) : base(id)
    {
    }
    
    public Url Url { get; private set; }
    public UserId UserId { get; private set; }
    public CompanyId CompanyId { get; private set; }
    
    public File HtmlFile { get; private set;}
    public File CSSFile { get; private set;}
    public File JSFile { get; private set;}
    public Counter HitCounter { get; private set;}
    
    public Status Status { get; private set; }
}


public record Status
{
}

public class File
{
}

public record Counter
{
    
}

public record Url
{
}