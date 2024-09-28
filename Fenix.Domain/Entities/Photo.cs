using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Path = Fenix.Domain.ValueObjects.Path;

namespace Fenix.Domain.Entities;

public class Photo : Shared.Entity<PhotoId>
{
    private Photo(
        PhotoId id,
        Path path) : base(id)
    {
        Path = path;
    }
    
    public Path Path { get; private set; }

    public static Result<Photo> Create (
        PhotoId id,
        Path path)
    {
        return new Photo(id, path);
    }
}