using CSharpFunctionalExtensions;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.SharedObjects;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Entities;

public class Company : Shared.Entity<CompanyId>
{
    private Company(
        CompanyId id,
        Name name,
        Industry industry,
        Phone companyPhone,
        IEnumerable<Social> socialMedia) : base(id)
    {
        Name = name;
        Industry = industry;
        CompanyPhone = companyPhone;
        _socialMedias = socialMedia.ToList();
    }

    public Name Name { get; private set; }
    public Industry Industry { get; private set; }
    public Phone CompanyPhone { get; private set; }

    public IReadOnlyList<Social> SocialMedias => _socialMedias;
    private readonly List<Social> _socialMedias = [];

    public static Result<Company, Error> Create(
        CompanyId id,
        Name name,
        Industry industry,
        Phone companyPhone,
        IEnumerable<Social> socialMedia)
    {
        return new Company(
            id,
            name,
            industry,
            companyPhone,
            socialMedia);
    }
}