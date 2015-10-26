using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using MyStoryboardApp.iOS.Views;
using UIKit;

namespace MyStoryboardApp.iOS
{
	public class Setup : MvxTouchSetup
	{
        public Setup(MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter)
            : base(appDelegate, presenter)
        {
        }

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxTouchViewsContainer CreateTouchViewsContainer()
        {
            return new StoryboardContainer();
        }
	}
}