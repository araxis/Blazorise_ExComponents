namespace Blazorise.ExComponents.Utilities;

public static class Extensions
{
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