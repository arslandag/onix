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

    public string Country { get; }
    public string City { get; }
    public string Street { get; }
    public string Build { get; }
    public string Index { get; }

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