namespace ClassLib;

public record Alarm<TValue>(string Key, AlarmType Type, TValue? TypedValue)
    : AlarmBase(Key, Type, TypedValue)
{
    public TValue? TypedValue { get; init; } = TypedValue;
}