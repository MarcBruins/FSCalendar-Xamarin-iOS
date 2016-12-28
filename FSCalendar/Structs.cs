using System;
using Foundation;
using ObjCRuntime;

    [Native]
    public enum FSCalendarFlow : long
    {
        Vertical,
        Horizontal
    }

    [Native]
    public enum FSCalendarCellShape : long
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
    public enum FSCalendarCellState : long
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
    public enum FSCalendarCaseOptions : long
    {
        HeaderUsesDefaultCase = 0,
        HeaderUsesUpperCase = 1,
        WeekdayUsesDefaultCase = 0 << 4,
        WeekdayUsesUpperCase = 1 << 4,
        WeekdayUsesSingleUpperCase = 2 << 4
    }

    [Native]
    public enum FSCalendarSeparators : long
    {
        None = 0,
        InterRows = 1 << 0,
        InterColumns = 1 << 1,
        BelowWeekdays = 1 << 2
    }

    [Native]
    public enum FSCalendarScope : long
    {
        Month,
        Week
    }

    [Native]
    public enum FSCalendarScrollDirection : long
    {
        Vertical,
        Horizontal
    }

    [Native]
    public enum FSCalendarPlaceholderType : long
    {
        None = 0,
        FillHeadTail = 1,
        FillSixRows = 2
    }

    [Native]
    public enum FSCalendarMonthPosition : long
    {
        Previous,
        Current,
        Next,
        NotFound = int.MaxValue
    }

    [Native]
    public enum FSCalendarTransition : long
    {
        None,
        MonthToWeek,
        WeekToMonth
    }

    [Native]
    public enum FSCalendarTransitionState : long
    {
        dle,
        nProgress
    }