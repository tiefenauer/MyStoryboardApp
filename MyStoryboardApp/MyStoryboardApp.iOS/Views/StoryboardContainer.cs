using System;
using System.Collections.Generic;
using System.Text;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using UIKit;

namespace MyStoryboardApp.iOS.Views
{
    public class StoryboardContainer : MvxTouchViewsContainer
    {
        protected override IMvxTouchView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            return (IMvxTouchView)UIStoryboard.FromName("Main", null)
                .InstantiateViewController(viewType.Name);
        }
    }
}
