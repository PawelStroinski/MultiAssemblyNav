using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.WindowsPhone.Platform;
using Microsoft.Phone.Controls;
using MvvmCross.WindowsPhone.Views;
using MultiAssemblyNav.Common;
using MultiAssemblyNav.Phone2.Views;

namespace MultiAssemblyNav.Phone1
{
    public class Setup : MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxPhoneViewsContainer CreateViewsContainer(PhoneApplicationFrame rootFrame)
        {
            var viewsContainer = new MultiAssemblyViewsContainer();
            var viewFinder = new LazyViewFinder(() => typeof(ThirdView).Assembly);
            viewsContainer.AddSecondary(viewFinder);
            return viewsContainer;
        }
    }
}
