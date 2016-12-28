using System;
using ObjCRuntime;

[Native]
public enum FSCalendarFlow : nint
{
    Vertical,
    Horizontal
}

[Native]
public enum FSCalendarCellShape : nuint
{
    Circle = 0,
    Rectangle = 1
}

[Native]
public enum FSCalendarUnit : nuint
{
    Month = NSCalendarUnitMonth,
    WeekOfYear = NSCalendarUnitWeekOfYear,
    Day = NSCalendarUnitDay
}

[Native]
public enum FSCalendarCellState : nint
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
public enum FSCalendarCaseOptions : nuint
{
    HeaderUsesDefaultCase = 0,
    HeaderUsesUpperCase = 1,
    WeekdayUsesDefaultCase = 0 << 4,
    WeekdayUsesUpperCase = 1 << 4,
    WeekdayUsesSingleUpperCase = 2 << 4
}

[Native]
public enum FSCalendarSeparators : nuint
{
    None = 0,
    InterRows = 1 << 0,
    InterColumns = 1 << 1,
    BelowWeekdays = 1 << 2
}

[Native]
public enum FSCalendarScope : nuint
{
    Month,
    Week
}

[Native]
public enum FSCalendarScrollDirection : nuint
{
    Vertical,
    Horizontal
}

[Native]
public enum FSCalendarPlaceholderType : nuint
{
    None = 0,
    FillHeadTail = 1,
    FillSixRows = 2
}

[Native]
public enum FSCalendarMonthPosition : nuint
{
    Previous,
    Current,
    Next,
    NotFound = NSNotFound
}

[Native]
public enum FSCalendarTransition : nuint
{
    None,
    MonthToWeek,
    WeekToMonth
}

[Native]
public enum FSCalendarTransitionState : nuint
{
    dle,
    nProgress
}
