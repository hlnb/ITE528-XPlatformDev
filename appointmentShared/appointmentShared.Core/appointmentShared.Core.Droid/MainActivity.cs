using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using appointmentShared;
using Parse;


[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar), typeof(Telerik.XamaarinForms.InputRenderer.Anddroid.CalendarRenderer))]
namespace appointmentShared.Droid
{
	[Activity (Label = "appointmentShared.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
            base.OnCreate(bundle);
            global::Xamarin.Forms.Init(this, bundle);

            App.AppointmentManager = new AppointmentManager(ParseStorage.Default);

            LoadApplication(new App());
			
		}
	}
}


