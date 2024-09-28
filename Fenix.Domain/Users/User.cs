using CSharpFunctionalExtensions;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.Users.ValueObjects;
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
        Phone phone) : base(id)
    {
        Email = email;
        PasswordHash = passwordHash;
        FullName = fullName;
        UserPhone = phone;
    }
    
    public Email Email { get; private set; }
    public PasswordHash PasswordHash { get; private set; }
    public FullName FullName { get; private set; }
    public Phone UserPhone { get; private set; }

    public IReadOnlyList<WebSite> WebSites => _webSites;
    private readonly List<WebSite> _webSites = [];

    public static Result<User, Error> Create(
        UserId id,
        Email email,
        PasswordHash passwordHash,
        FullName fullName, 
        Phone phone)
    {
        return new User(
            id,
            email,
            passwordHash,
            fullName,
            phone);
    }
}