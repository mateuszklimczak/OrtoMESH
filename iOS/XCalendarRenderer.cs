using OrtoMESH;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using OrtoMESH.iOS;


[assembly: ExportRenderer(typeof(CalendarPage), typeof(XCalendarViewController))]
namespace OrtoMESH.iOS
{
	class XCalendarRenderer : PageRenderer
	{
		UIWindow window;

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var page = e.NewElement as CalendarPage;


			var view = NativeView;

			// create a new window instance based on the screen size
			window = new UIWindow(UIScreen.MainScreen.Bounds);

			//var nav = new UINavigationController(new );
			// If you have defined a view, add it here:
			// window.RootViewController  = navigationController;
			//window.RootViewController = XCalendarViewController;

			// make the window visible
			window.MakeKeyAndVisible();

		}
	}
}