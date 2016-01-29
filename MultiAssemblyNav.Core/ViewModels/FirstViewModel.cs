using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace MultiAssemblyNav.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        public ICommand GoToSecond
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<SecondViewModel>();
                });
            }
        }

        public ICommand GoToThird
        {
            get
            {
                return new MvxCommand(() =>
                {
                    ShowViewModel<ThirdViewModel>();
                });
            }
        }
    }
}
