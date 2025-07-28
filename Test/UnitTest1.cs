using ClassLib;
using Shouldly;

namespace Test;


public class Tests
{
    [Test]
    public void Test1()
    {
        AlarmBase[] alarmArray =
        [
            new("A1", AlarmType.Info, true),
            new("A2", AlarmType.Info, 42),
            new("A3", AlarmType.Error, false),
            new("A4", AlarmType.Critical, "not a bool"),
            new("A5", AlarmType.Critical, true),
            new("A6", AlarmType.Critical, 123)
        ];

        var result = alarmArray.AsGroupedAlarmDictionary<bool?>();

        result.Count.ShouldBe(4);
        result.Keys.ShouldBe(Enum.GetValues<AlarmType>(), ignoreOrder: true);

        // Info
        result[AlarmType.Info].Count.ShouldBe(2);
        result[AlarmType.Info][0].Key.ShouldBe("A1");
        result[AlarmType.Info][0].TypedValue.ShouldBe(true);
        result[AlarmType.Info][1].Key.ShouldBe("A2");
        result[AlarmType.Info][1].TypedValue.ShouldBeNull();

        // Warning
        result[AlarmType.Warning].ShouldNotBeNull();
        result[AlarmType.Warning].Count.ShouldBe(0);

        // Error
        result[AlarmType.Error].Count.ShouldBe(1);
        result[AlarmType.Error][0].Key.ShouldBe("A3");
        result[AlarmType.Error][0].TypedValue.ShouldBe(false);

        // Critical
        var critical = result[AlarmType.Critical];
        critical.Count.ShouldBe(3);

        critical[0].Key.ShouldBe("A4");
        critical[0].TypedValue.ShouldBeNull();

        critical[1].Key.ShouldBe("A5");
        critical[1].TypedValue.ShouldBe(true);

        critical[2].Key.ShouldBe("A6");
        critical[2].TypedValue.ShouldBeNull();
    }
}