﻿using System;

public class WeekbasedDateTimeInterval
{
    public const int minutesInWeek = 60 * 24 * 7;
    
    // January 1st of year 1 was a Monday.
    private const Int32 baseYear = 1;
    private const Int32 baseMonth = 1;
    private const Int32 baseSeconds = 0;

    private DateTime start;
    private DateTime end;

    public WeekbasedDateTimeInterval(DayOfWeek startDay, Int32 startHours, Int32 startMinutes, DayOfWeek endDay, Int32 endHours, Int32 endMinutes)
    {
        Int32 settingDay;

        settingDay = ToIntBaseMonday(startDay) + 1;
        start = new DateTime(baseYear, baseMonth, settingDay, startHours, startMinutes, baseSeconds);

        settingDay = ToIntBaseMonday(endDay) + 1;
        end = new DateTime(baseYear, baseMonth, settingDay, endHours, endMinutes, baseSeconds);
    }

    public bool Contains(DateTime checkingDateTime)
    {
        bool isTimeAfterStart = checkingDateTime.TimeOfDay >= start.TimeOfDay;
        bool isTimeBeforeEnd = checkingDateTime.TimeOfDay < end.TimeOfDay;
        bool isDayAfterStart = ToIntBaseMonday(checkingDateTime.DayOfWeek) >= ToIntBaseMonday(start.DayOfWeek);
        bool isDayBeforeEnd = ToIntBaseMonday(checkingDateTime.DayOfWeek) <= ToIntBaseMonday(end.DayOfWeek);

        return (isTimeAfterStart && isTimeBeforeEnd && isDayAfterStart && isDayBeforeEnd);
    }

    private static Int32 ToIntBaseMonday(DayOfWeek convertingDay)
    {
        const Int32 baseSunday = 6;

        if (convertingDay != DayOfWeek.Sunday)
        {
            return (Int32)convertingDay - 1;
        }
        else
        {
            return baseSunday;
        }
    }
}
