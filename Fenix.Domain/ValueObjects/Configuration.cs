using CSharpFunctionalExtensions;

namespace Fenix.Domain.ValueObjects;

public class Configuration
{
    public Configuration(
        IEnumerable<Block> blocks,
        Appearance appearance)
    {
        _blocks = blocks.ToList();
        Appearance = appearance;
    }

    public IReadOnlyList<Block> Blocks => _blocks;
    private readonly List<Block> _blocks = [];
    
    public Appearance Appearance { get; private set; }    

    public static Result<Configuration> Create(
        IEnumerable<Block> blocks,
        Appearance appearance)
    {
        return new Configuration(blocks, appearance);
    }
}