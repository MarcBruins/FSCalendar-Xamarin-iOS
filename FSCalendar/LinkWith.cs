using ObjCRuntime;

[assembly: LinkWith("libFSCalendar.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, SmartLink = true, ForceLoad = true, LinkerFlags = "-ObjC -fobjc-arc")]