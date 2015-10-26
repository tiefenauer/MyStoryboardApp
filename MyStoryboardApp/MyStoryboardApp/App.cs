using Cirrious.CrossCore.IoC;
using MyStoryboardApp.ViewModels;

namespace MyStoryboardApp
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<MainViewModel>();
        }
    }
}