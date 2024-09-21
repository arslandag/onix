using System.Net.Mime;
using CSharpFunctionalExtensions;
using Fenix.Domain.Entities;

namespace Fenix.Domain.ValueObjects;

public class Appearance
{
    private Appearance(
        ColorScheme colorScheme,
        int buttonAngle,
        ButtonStyle buttonStyle,
        Font font, 
        Photo favicon)
    {
        ColorScheme = colorScheme;
        ButtonAngle = buttonAngle;
        ButtonStyle = buttonStyle;
        Font = font;
        Favicon = favicon;
    }

    public ColorScheme ColorScheme { get; }
    public int ButtonAngle { get; } 
    public ButtonStyle ButtonStyle { get; }
    public Font Font { get; }
    public Photo Favicon { get; }

    public static Result<Appearance> Create(
        ColorScheme colorScheme,
        int buttonAngle,
        ButtonStyle buttonStyle,
        Font font,
        Photo favicon)
    {
        return new Appearance(
            colorScheme,
            buttonAngle,
            buttonStyle,
            font,
            favicon);
    }
}