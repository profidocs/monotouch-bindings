using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libGoogleAnalytics.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, "-lsqlite3.0", Frameworks = "CFNetwork", ForceLoad = true)]
