namespace Blazorise.ExComponents.Utilities;

public record MeasureValue
{
    internal MeasureValue(double value, string unit)
    {
        this.Value = value;
        this.Unit = unit;
    }

    public override string ToString() => $"{Value}{Unit}";
    public double Value { get; init; }
    public string Unit { get; init; }

    public void Deconstruct(out double value, out string unit)
    {
        value = this.Value;
        unit = this.Unit;
    }

    public static MeasureValue operator /(MeasureValue param, int value) => param with { Value =param.Value/value };
}