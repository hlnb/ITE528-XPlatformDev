using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using Xamarin.Forms;
using Syncfusion.SfSchedule.XForms;
using apptSched;


namespace apptSched
{
	public partial class AppointmentView : ContentPage
	{
		
		public AppointmentView ()
		{
			ScheduleAppointmentCollection AppColl;
			DateTime date = DateTime.Now;

			InitializeComponent ();

			AppColl = new ScheduleAppointmentCollection
			{
				new ScheduleAppointment { Subject = "Meeting", StartTime = date.AddHours(0), EndTime = date.AddHours(2) },
				new ScheduleAppointment { Subject = "Conference", StartTime = date.AddDays(-30).AddHours(0), EndTime = date.AddDays(-30).AddHours(2)},
				new ScheduleAppointment { Subject = "Travelling", StartTime = date.AddDays(3).AddHours(0), EndTime = date.AddDays(3).AddHours(2) },
				new ScheduleAppointment { Subject = "Treatment", StartTime = date.AddDays(5).AddHours(0), EndTime = date.AddDays(5).AddHours(2) },
				new ScheduleAppointment { Subject = "School", StartTime = date.AddHours(5), EndTime = date.AddHours(7) },
				new ScheduleAppointment { Subject = "Meeting", StartTime = date.AddDays(-35).AddHours(0), EndTime = date.AddDays(-35).AddHours(2)},
				new ScheduleAppointment { Subject = "Birthday", StartTime = date.AddDays(29).AddHours(0), EndTime = date.AddDays(3).AddHours(2) },
				new ScheduleAppointment { Subject = "Treatment", StartTime = date.AddDays(20).AddHours(0), EndTime = date.AddDays(5).AddHours(2) },
			};
			//Adding appointment in sfschedule
			schedule.DataSource = AppColl;

			schedule.ScheduleCellTapped += schedule_ScheduleCellTapped;

			}

		}

}
