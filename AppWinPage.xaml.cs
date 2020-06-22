using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.WindowManagement;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Windowing_Modes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        AppWindow view;

        public AppWindow MyAppWindow { get; set; }

        public BlankPage2()
        {
            this.InitializeComponent();

            Loaded += AppWindowPage_Loaded;
        }

        private void AppWindowPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Get the reference to this AppWindow that was stored when it was created.
            view = MainPage.AppWindows[this.UIContext];
        }

        private void FullScreen_Launch(object sender, RoutedEventArgs e)
        {
            if (view.Presenter.GetConfiguration().Kind != AppWindowPresentationKind.FullScreen)
            {
                view.Presenter.RequestPresentation(AppWindowPresentationKind.FullScreen);
            }
        }

        private void CO_Launch(object sender, RoutedEventArgs e)
        {
            if (view.Presenter.GetConfiguration().Kind != AppWindowPresentationKind.CompactOverlay)
            {
                view.Presenter.RequestPresentation(AppWindowPresentationKind.CompactOverlay);
            }
        }

        private void Default_Launch(object sender, RoutedEventArgs e)
        {
            if (view.Presenter.GetConfiguration().Kind != AppWindowPresentationKind.Default)
            {
                view.Presenter.RequestPresentation(AppWindowPresentationKind.Default);
            }
        }
    }
}
