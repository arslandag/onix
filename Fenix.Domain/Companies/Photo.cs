using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Path = Fenix.Domain.ValueObjects.Path;

namespace Fenix.Domain.Companies;

public class Photo : Shared.Entity<PhotoId>
{
    private Photo(PhotoId id,Path path, bool isMain) : base(id)
    {
        Path = path;
        IsMain = isMain;
    }
    
    public Path Path { get; private set; }
    public bool IsMain { get; private set; }

    public static Result<Photo> Create(PhotoId id,Path path, bool isMain)
    {
        return new Photo(id, path, isMain);
    }
}