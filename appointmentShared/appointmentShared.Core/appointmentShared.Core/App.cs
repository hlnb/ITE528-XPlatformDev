using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace appointmentShared.Core
{
    public class App : Application
    {
        public static appointmentManager AppointmentManager { get; set; }
        public App()
        {
            // The root page of application
            MainPage = new NavigationPage(new appointmentsPage());
        }
    }
}

