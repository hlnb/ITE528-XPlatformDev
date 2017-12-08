using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace appointmentShared.Core
{
    public partial class appointmentsPage : ContentPage
    {
        //populating appointment collection
        static appointmentsPage()
        {
            MyStaticFields.Appointments = new ObservableCollection<appointment>()
            {
                new appointment()
                {
                    StartDate = DateTime.Now.AddDays(-1),
                    EndDate = DateTime.Now.AddDays(-1).AddMinutes(-1),
                    Title="Call Steve",
                    IsAllDay = false,
                    Color = Color.Red
                }
            };
            MyStaticFields.Appointments.Add(new appointment()
            {
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(1).AddMinutes(1),
                Title = "Collect Tickets",
                IsAllDay = false,
                Color = Color.Blue
            });

            MyStaticFields.Appointments.Add(new appointment()
            {
                StartDate = DateTime.Now.AddDays(3),
                EndDate = DateTime.Now.AddDays(3).AddMinutes(3),
                Title = "Travel to Sydney",
                IsAllDay = true,
                Color = Color.Blue
            });
        }

        public appointmentsPage()
        {
            InitializeComponent();
            calendar.AppointmentsSource = MyStaticFields.Appointments;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.AppointmentManager.GetAppointmentAsync();
        }

        void OnAddItemActivated(object sender, EventArgs args)
        {
            var Appointment = new appointment();
            var addAppointmentPage = new AddAppointmentPage();

            addAppointmentPage.BindingContext = Appointment;
            Navigation.PushAsync(addAppointmentPage);
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Appointment = e.SelectedItem as appointment;
            var editAppointmentPage = new AddAppointmentPage();
            editAppointmentPage.BindingContext = Appointment;

            Navigation.PushAsync(editAppointmentPage);
        }

       

    }
}
