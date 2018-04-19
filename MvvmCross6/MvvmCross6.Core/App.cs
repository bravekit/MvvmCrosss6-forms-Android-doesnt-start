using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MvvmCross6.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.MainViewModel>();
        }


    }
}
