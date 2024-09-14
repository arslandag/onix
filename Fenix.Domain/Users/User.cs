using CSharpFunctionalExtensions;
using Fenix.Domain.Companies;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.ValueObjects;
using Fenix.Domain.WebSites;

namespace Fenix.Domain.Users;

public class User : Shared.Entity<UserId>
{
    private User(
        UserId id,
        Email email,
        PasswordHash passwordHash,
        FullName fullName, 
        Phone phone,
        IEnumerable<Company> companies,
        IEnumerable<WebSite> webSites) : base(id)
    {
        Email = email;
        PasswordHash = passwordHash;
        FullName = fullName;
        UserPhone = phone;
        _companies = companies.ToList();
        _webSites = webSites.ToList();
    }
    
    public Email Email { get; private set; }
    public PasswordHash PasswordHash { get; private set; }
    public FullName FullName { get; private set; }
    public Phone UserPhone { get; private set; }

    public IReadOnlyList<Company> Company => _companies;
    private readonly List<Company> _companies = [];

    public IReadOnlyList<WebSite> WebSites => _webSites;
    private readonly List<WebSite> _webSites = [];

    public static Result<User, Error> Create(
        UserId id,
        Email email,
        PasswordHash passwordHash,
        FullName fullName, 
        Phone phone,
        IEnumerable<Company> companies,
        IEnumerable<WebSite> webSites)
    {
        return new User(
            id,
            email,
            passwordHash,
            fullName,
            phone,
            companies,
            webSites);
    }
}