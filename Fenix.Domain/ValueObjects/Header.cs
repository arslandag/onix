using CSharpFunctionalExtensions;
using Fenix.Domain.Entities;
using Fenix.Domain.SharedObjects;

namespace Fenix.Domain.ValueObjects;

public class Header
{
    private Header(
        Name name,
        Phone phone,
        IEnumerable<Social> socialMedias)
    {
        Name = name;
        Phone = phone;
        _socialMedias = socialMedias.ToList();
    }
    
    public Name Name { get; }
    public Phone Phone { get; }
    
    public IReadOnlyList<Social> SocialMedias => _socialMedias;
    private readonly List<Social> _socialMedias = [];

    public static Result<Header> Create(
        Name name,
        Phone phone,
        IEnumerable<Social> socialMedias)
    {
        return new Header(name,phone, socialMedias);
    }
}