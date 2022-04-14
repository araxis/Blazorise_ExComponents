using EitherResult;

namespace Blazorise.ExComponents.Utilities;

public static class Extensions
{

    public static string ToBackground(this Background color,Theme? theme)
    {
        var options = theme?.BackgroundOptions ?? new ThemeBackgroundOptions();
        if (color == Background.Danger) return options.Danger;
        if (color == Background.Dark) return options.Dark;
        if (color == Background.Default) return options.Light;
        if (color == Background.Info) return options.Info;
        if (color == Background.Light) return options.Light;
        if (color == Background.Transparent) return "transparent";
        if (color == Background.Primary) return options.Primary;
        if (color == Background.Secondary) return options.Secondary;
        if (color == Background.Success) return options.Success;
        return color == Background.Warning ? options.Warning : options.Light;
    }

    public static string ToTextColor(this TextColor color, Theme? theme)
    {
        var options = theme?.TextColorOptions ?? new ThemeTextColorOptions();
        if (color == TextColor.Danger) return options.Danger;
        if (color == TextColor.Dark) return options.Dark;
        if (color == TextColor.Default) return options.Light;
        if (color == TextColor.Info) return options.Info;
        if (color == TextColor.Light) return options.Light;
        if (color == TextColor.Black50) return options.Black50;
        if (color == TextColor.Body) return options.Body;
        if (color == TextColor.Muted) return options.Muted;
        if (color == TextColor.Primary) return options.Primary;
        if (color == TextColor.Secondary) return options.Secondary;
        if (color == TextColor.Success) return options.Success;
        return color == TextColor.Warning ? options.Warning : options.Light;
    }

    public static string ToTextColor(this Either<string,TextColor> color, Theme? theme)
    {
        return color.Fold(s => s, c => c.ToTextColor(theme));
    }

    public static string ToBackground(this Either<string,Background> color, Theme? theme)
    {
        return color.Fold(s => s, c => c.ToBackground(theme));
    }
    public static Background ToBackground(this Color color)
    {
        if (color == Color.Danger) return Background.Danger;
        if (color == Color.Dark) return Background.Dark;
        if (color == Color.Default) return Background.Default;
        if (color == Color.Info) return Background.Info;
        if (color == Color.Light) return Background.Light;
        if (color == Color.Link) return Background.Light;
        if (color == Color.Primary) return Background.Primary;
        if (color == Color.Secondary) return Background.Secondary;
        if (color == Color.Success) return Background.Success;
        return color == Color.Warning ? Background.Warning : Background.Default;
    }

    public static string ToTextColor(this Color color,Theme? theme)
    {
        var options = theme?.TextColorOptions ?? new ThemeTextColorOptions();
        if (color == Color.Danger) return options.Danger;
        if (color == Color.Dark) return options.Dark;
        if (color == Color.Default) return options.Light;
        if (color == Color.Info) return options.Info;
        if (color == Color.Light) return options.Light;
        if (color == Color.Link) return options.Light;
        if (color == Color.Primary) return options.Primary;
        if (color == Color.Secondary) return options.Secondary;
        if (color == Color.Success) return options.Success;
        return color == Color.Warning ? options.Warning : options.Light;
    }

    public static string ToBackgroundColor(this Color color, Theme? theme)
    {
        var options = theme?.BackgroundOptions ?? new ThemeBackgroundOptions();
        if (color == Color.Danger) return options.Danger;
        if (color == Color.Dark) return options.Dark;
        if (color == Color.Default) return options.Light;
        if (color == Color.Info) return options.Info;
        if (color == Color.Light) return options.Light;
        if (color == Color.Link) return options.Light;
        if (color == Color.Primary) return options.Primary;
        if (color == Color.Secondary) return options.Secondary;
        if (color == Color.Success) return options.Success;
        return color == Color.Warning ? options.Warning : options.Light;
    }

    public static double PercentageToDegree(this double value) => value switch
        {
            < 0 => 0,
            > 100 => 360,
            _ => 360 * value / 100
        };

    public static double Map(double value, double minValue, double maxValue, double targetMin, double targetMax)
    {
        return (value - minValue) / (maxValue - minValue) * (targetMax - targetMin) + targetMin;
    }

    public static double MapToDegree(double value, double minValue, double maxValue)
    {
        return (value - minValue) / (maxValue - minValue) * 360 ;
    }

    public static double MapToDegree(this double value,double maxValue)
    {
        return (value) / maxValue * 360;
    }

    public static string ToTextColor(this Either<string,Color> color, Theme? theme)
    {
        return color.Fold(s => s, c => c.ToTextColor(theme));
    }

    public static string ToBackgroundColor(this Either<string, Color> color, Theme? theme)
    {
        return color.Fold(s => s, c => c.ToBackgroundColor(theme));
    }



    public static TextColor ToTextColor(this Color color)
    {
        if (color == Color.Danger) return TextColor.Danger;
        if (color == Color.Dark) return TextColor.Dark;
        if (color == Color.Default) return TextColor.Default;
        if (color == Color.Info) return TextColor.Info;
        if (color == Color.Light) return TextColor.Light;
        if (color == Color.Link) return TextColor.Light;
        if (color == Color.Primary) return TextColor.Primary;
        if (color == Color.Secondary) return TextColor.Secondary;
        if (color == Color.Success) return TextColor.Success;
        return color == Color.Warning ? TextColor.Warning : TextColor.Default;
    }

    public static HeadingSize ToHeadingSize(this Size size) => size switch
    {
        Size.Default => HeadingSize.Is4,
        Size.ExtraSmall => HeadingSize.Is6,
        Size.Small => HeadingSize.Is5,
        Size.Medium => HeadingSize.Is3,
        Size.Large => HeadingSize.Is2,
        Size.ExtraLarge => HeadingSize.Is1,
        _ => throw new ArgumentOutOfRangeException(nameof(size), size, null)
    };
    public static bool IsToday(this DateTime date) => DateTime.Now.Date == date.Date;

    public static MeasureValue px(this double value) => new(value, "px");
    public static MeasureValue p(this double value) => new(value, "%");
    public static MeasureValue rem(this double value) => new(value, "rem");

    public static MeasureValue px(this int value) => new(value, "px");
    public static MeasureValue p(this int value) => new(value, "%");
    public static MeasureValue rem(this int value) => new(value, "rem");
}