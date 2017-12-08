using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Input;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641
[assembly:Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Input.RadCalendar),typeof(Telerik.XamarinForms.InputRenderer.WinPhone.CalendarRenderer))]
namespace appointmentShared.Core.WinPhone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MainPage : global::Xamarin.Forms.Platform.WinRT.FormsApplicationPage
    {
        public MainPage()
        {

            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitorLandscape;

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new appointmentShared.Core.App());
        }
    }
}
