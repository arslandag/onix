using CSharpFunctionalExtensions;
using Fenix.Domain.Entities;
using Fenix.Domain.SharedObjects;

namespace Fenix.Domain.ValueObjects;

public class TextBlock : Block
{
    private TextBlock(
        Title title,
        Description description,
        Photo photo,
        ShowStatus showStatus)
    {
        Title = title;
        Description = description;
        Photo = photo;
        ShowStatus = showStatus;
    }

    public Title Title { get; }
    public Description Description { get; }
    public Photo Photo { get; }
    public ShowStatus ShowStatus { get; }
    
    public static Result<TextBlock> Create(
        Title title,
        Description description,
        Photo photo,
        ShowStatus showStatus)
    {
        return new TextBlock(
            title,
            description,
            photo,
            showStatus);
    }
}