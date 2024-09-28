using CSharpFunctionalExtensions;
using Fenix.Domain.Entities;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.ValueObjects;
using Fenix.Domain.WebSites.Blocks;
using Fenix.Domain.WebSites.ValueObjects;
using Fenix.Domain.WebSites.ValueObjects.Configs;

namespace Fenix.Domain.WebSites;

public class WebSite : Shared.Entity<WebSiteId>
{
    private WebSite(
        WebSiteId id,
        Url url,
        Name name,
        Phone phone,
        ShowStatus showStatus,
        Appearance appearance,
        Photo favicon) : base(id)
    {
        Url = url;
        Name = name;
        Phone = phone;
        ShowStatus = showStatus;
        Appearance = appearance;
        Favicon = favicon;
    }
    
    public Url Url { get; private set; }
    public Name Name { get; }
    public Phone Phone { get; }
    public ShowStatus ShowStatus { get; private set; }
    public Appearance Appearance { get; private set; }
    
    public Photo Favicon { get; private set; }
    
    public IReadOnlyList<SocialMedia> SocialMedias => _socialMedias;
    private readonly List<SocialMedia> _socialMedias = [];
    
    public IReadOnlyList<Block> Blocks => _blocks;
    private readonly List<Block> _blocks = [];
    
    public static Result<WebSite> Create(
        WebSiteId id,
        Url url,
        Name name,
        Phone phone,
        ShowStatus showStatus,
        Appearance appearance,
        Photo favicon)
    {
        return new WebSite(
            id,
            url,
            name,
            phone,
            showStatus,
            appearance,
            favicon);
    }
}