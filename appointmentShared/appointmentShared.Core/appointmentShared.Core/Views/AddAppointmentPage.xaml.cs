using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace appointmentShared.Core
{
    public partial class AddAppointmentPage : ContentPage
    {
        public AddAppointmentPage()
        {
            InitializeComponent();
        }
        
        async void OnSaveActivated(object sender, EventArgs e)
        {
            var Appointment = (appointment)BindingContext;
            await App.AppointmentManager.SaveAppointmentAsync(Appointment);
            await Navigation.PopAsync();
        }

        async void OnDeleteActivated(object sender, EventArgs e)
        {
            var Appointment = (appointment)BindingContext;
            await App.AppointmentManager.DeleteAppointmentAsync(Appointment);
            await Navigation.PopAsync();
        }

        void OnCancelActivated(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
