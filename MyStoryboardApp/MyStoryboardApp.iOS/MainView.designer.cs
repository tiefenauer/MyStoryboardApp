// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyStoryboardApp.iOS
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton NavigationEventButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton NavigationMvXButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton NavigationSegueButton { get; set; }

		[Action ("NavigationEventButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void NavigationEventButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (NavigationEventButton != null) {
				NavigationEventButton.Dispose ();
				NavigationEventButton = null;
			}
			if (NavigationMvXButton != null) {
				NavigationMvXButton.Dispose ();
				NavigationMvXButton = null;
			}
			if (NavigationSegueButton != null) {
				NavigationSegueButton.Dispose ();
				NavigationSegueButton = null;
			}
		}
	}
}
