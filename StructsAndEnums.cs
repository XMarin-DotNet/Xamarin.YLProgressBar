using System;
using ObjCRuntime;

[Native]
public enum YLProgressBarType : nuint
{
	Rounded = 0,
	Flat = 1
}

[Native]
public enum YLProgressBarStripesOrientation : nuint
{
	Right = 0,
	Left = 1,
	Vertical = 2
}

[Native]
public enum YLProgressBarStripesDirection : nint
{
	Left = -1,
	Right = 1
}

[Native]
public enum YLProgressBarBehavior : nuint
{
	Default = 0,
	Indeterminate = 1,
	Waiting = 2
}

[Native]
public enum YLProgressBarIndicatorTextDisplayMode : nuint
{
	None = 0,
	Track = 1,
	Progress = 2
}
