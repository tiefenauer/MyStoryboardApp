using Foundation;
using System;
using System.CodeDom.Compiler;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using MyStoryboardApp.ViewModels;
using UIKit;

namespace MyStoryboardApp.iOS
{
	partial class MainView : MvxViewController
	{
		public MainView (IntPtr handle) : base (handle)
		{
		}

	    public new MainViewModel ViewModel
	    {
            get { return (MainViewModel) base.ViewModel; }
            set { base.ViewModel = value; }
	    }

        /// <summary>
        /// Variant 1: Using MvX binding functionality for navigation
        /// </summary>
	    public override void ViewDidLoad()
	    {
	        base.ViewDidLoad();
	        this.CreateBinding(NavigationMvXButton).To<MainViewModel>(vm => vm.ShowOtherView);
	    }


	    /// <summary>
        /// Variant 2: Navigation using event listener and manual execution of command
        /// </summary>
        /// <param name="sender"></param>
        partial void NavigationEventButton_TouchUpInside(UIButton sender)
        {
            ViewModel.ShowOtherView.Execute(sender);
        }

        /// <summary>
        /// Variant 3: Navigation using segues
        /// </summary>
        /// <param name="segue"></param>
        /// <param name="sender"></param>
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "showOtherView")
            {
                var otherView = segue.DestinationViewController as OtherView;
                if (otherView != null)
                {
                    otherView.Request = new MvxViewModelRequest<OtherViewModel>(null, null, new MvxRequestedBy());
                }
            }
        }
	}
}
