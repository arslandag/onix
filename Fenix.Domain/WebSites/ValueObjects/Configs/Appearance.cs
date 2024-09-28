using CSharpFunctionalExtensions;
using Fenix.Domain.Entities;

namespace Fenix.Domain.WebSites.ValueObjects.Configs;

public class Appearance
{
    private Appearance(
        string colorScheme,
        int buttonAngle,
        string buttonStyle,
        string font)
    {
        ColorScheme = colorScheme;
        ButtonAngle = buttonAngle;
        ButtonStyle = buttonStyle;
        Font = font;
    }

    public string ColorScheme { get; }
    public int ButtonAngle { get; }

    public string ButtonStyle { get; }
    public string Font { get; }

    public static Result<Appearance> Create(
        string colorScheme,
        int buttonAngle,
        string buttonStyle,
        string font)
    {
        return new Appearance(
            colorScheme,
            buttonAngle,
            buttonStyle,
            font);
    }
}