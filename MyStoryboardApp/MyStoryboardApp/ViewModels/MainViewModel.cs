using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace MyStoryboardApp.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private ICommand _showOtherView;

        public ICommand ShowOtherView
        {
            get
            {
                if (_showOtherView == null)
                    _showOtherView = new MvxCommand(() => ShowViewModel<OtherViewModel>());
                return _showOtherView;
            }            
        }
    }
}
