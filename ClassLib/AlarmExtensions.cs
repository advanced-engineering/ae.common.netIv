using System.Collections.ObjectModel;

namespace ClassLib;

public static class AlarmExtensions
{
    public static ReadOnlyDictionary<AlarmType, List<Alarm<TValue>>> AsGroupedAlarmDictionary<TValue>(this AlarmBase[] alarms)
    {
        // TODO: Implement this method
        return ReadOnlyDictionary<AlarmType, List<Alarm<TValue>>>.Empty;
    }
}