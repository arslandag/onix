using CSharpFunctionalExtensions;

namespace Fenix.Domain.ValueObjects;

public class Appearance
{
    private Appearance(
        ColorScheme colorScheme,
        int buttonAngle,
        ButtonStyle buttonStyle)
    {
        ColorScheme = colorScheme;
        ButtonAngle = buttonAngle;
        ButtonStyle = buttonStyle;
    }

    public ColorScheme ColorScheme { get; }
    public int ButtonAngle { get; } 
    public ButtonStyle ButtonStyle { get; }

    public static Result<Appearance> Create(
        ColorScheme colorScheme,
        int buttonAngle,
        ButtonStyle buttonStyle)
    {
        return new Appearance(
            colorScheme,
            buttonAngle,
            buttonStyle);
    }
}