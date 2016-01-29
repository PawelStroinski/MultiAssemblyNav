using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Core.Views;
using MultiAssemblyNav.Droid2.Views;
using MvvmCross.Droid.Views;
using MultiAssemblyNav.Common;

namespace MultiAssemblyNav.Droid1
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
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

        protected override IMvxAndroidViewsContainer CreateViewsContainer(Context applicationContext)
        {
            var viewsContainer = base.CreateViewsContainer(applicationContext);
            var viewFinder = new LazyViewFinder(() => typeof(ThirdView).Assembly);
            ((IMvxViewsContainer)viewsContainer).AddSecondary(viewFinder);
            return viewsContainer;
        }
    }
}
