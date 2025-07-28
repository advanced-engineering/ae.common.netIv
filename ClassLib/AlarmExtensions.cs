using System.Collections.ObjectModel;

namespace ClassLib;

public static class AlarmExtensions
{
    // TODO: Implement this method
    /// <summary>
    /// Converts an array of <see cref="AlarmBase"/> into a <see cref="ReadOnlyDictionary{TKey, TValue}"/>  where alarms are grouped by <see cref="AlarmType"/>.
    /// Each group's values are set as <typeparamref name="TValue"/>  when the type of <see cref="AlarmBase.Value"/> matches, or set to null otherwise.
    /// Ensures all <see cref="AlarmType"/> enum values are included, even if no alarms exist for a specific type.
    /// </summary>
    public static ReadOnlyDictionary<AlarmType, List<Alarm<TValue>>> AsGroupedAlarmDictionary<TValue>(this AlarmBase[] alarms)
    {
        // TODO: Implement this method
        return ReadOnlyDictionary<AlarmType, List<Alarm<TValue>>>.Empty;
    }
}