using Foundation;
using UIKit;
using appointmentShared.Core;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer))]
namespace appointmentShared.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register ("AppDelegate")]
	public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.InputRenderer.iOS.CalendarRenderer();

            global::Xamarin.Forms.Forms.Init();

            App.AppointmentManager = new appointmentManager(ParseStorage.Default);

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
	}
}


