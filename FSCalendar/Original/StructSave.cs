using System;
using Foundation;
using ObjCRuntime;

namespace FSCalendar
{
    [Native]
    public enum FSCalendarFlow : int
    {
        Vertical,
        Horizontal
    }

    [Native]
    public enum FSCalendarCellShape : int
    {
        Circle = 0,
        Rectangle = 1
    }

    [Native]
    public enum FSCalendarUnit : ulong
    {
        Month = NSCalendarUnit.Month,
        WeekOfYear = NSCalendarUnit.Week,
        Day = NSCalendarUnit.Day
    }

    [Native]
    public enum FSCalendarCellState : int
    {
        Normal = 0,
        Selected = 1,
        Placeholder = 1 << 1,
        Disabled = 1 << 2,
        Today = 1 << 3,
        Weekend = 1 << 4,
        TodaySelected = Today | Selected
    }

    [Native]
    public enum FSCalendarCaseOptions : int
    {
        HeaderUsesDefaultCase = 0,
        HeaderUsesUpperCase = 1,
        WeekdayUsesDefaultCase = 0 << 4,
        WeekdayUsesUpperCase = 1 << 4,
        WeekdayUsesSingleUpperCase = 2 << 4
    }

    [Native]
    public enum FSCalendarSeparators : int
    {
        None = 0,
        InterRows = 1 << 0,
        InterColumns = 1 << 1,
        BelowWeekdays = 1 << 2
    }

    [Native]
    public enum FSCalendarScope : int
    {
        Month,
        Week
    }

    [Native]
    public enum FSCalendarScrollDirection : int
    {
        Vertical,
        Horizontal
    }

    [Native]
    public enum FSCalendarPlaceholderType : int
    {
        None = 0,
        FillHeadTail = 1,
        FillSixRows = 2
    }

    [Native]
    public enum FSCalendarMonthPosition : int
    {
        Previous,
        Current,
        Next,
        NotFound = int.MaxValue
    }

    [Native]
    public enum FSCalendarTransition : int
    {
        None,
        MonthToWeek,
        WeekToMonth
    }

    [Native]
    public enum FSCalendarTransitionState : int
    {
        dle,
        nProgress
    }
}
