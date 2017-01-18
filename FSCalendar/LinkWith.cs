using ObjCRuntime;

[assembly: LinkWith("libFSCalendar.a",
					LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64,
					Frameworks = "UIKit Foundation CoreGraphics",
					SmartLink = true,
					ForceLoad = true,
					LinkerFlags = "-ObjC -fobjc-arc")]