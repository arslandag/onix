using CSharpFunctionalExtensions;

namespace Fenix.Domain.ValueObjects;

public record Address
{
    private Address(
        string country,
        string city,
        string street,
        string build,
        string index)
    {
        Country = country;
        City = city;
        Street = street;
        Build = build;
        Index = index;
    }

    public string Country { get; init; }
    public string City { get; init; }
    public string Street { get; init; }
    public string Build { get; init;}
    public string Index { get; init;}

    public static Result<Address> Create(
        string country,
        string city,
        string street,
        string build,
        string index
    )
    {
        return new Address(
            country,
            city,
            street,
            build,
            index);
    }
}