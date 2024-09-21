using CSharpFunctionalExtensions;
using Fenix.Domain.SharedObjects;

namespace Fenix.Domain.ValueObjects;

public class TextBlock : Block
{
    private TextBlock(Name name,
        Description description,
        ShowStatus showStatus)
    {
        Name = name;
        Description = description;
        ShowStatus = showStatus;
    }

    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public ShowStatus ShowStatus { get; private set; }
    
    public static Result<TextBlock> Create(
        Name name,
        Description description,
        ShowStatus showStatus)
    {
        return new TextBlock(
            name,
            description,
            showStatus);
    }
}