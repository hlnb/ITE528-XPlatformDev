using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Parse;
using appointmentShared.Core;

namespace appointmentShared.Droid
{
    public class ParseStorage : IParseStorage
    {
        static ParseStorage appointmentServiceInstance = new ParseStorage();
        public static ParseStorage Default { get { return appointmentServiceInstance; } }

        public List<appointment> Appointments { get; private set; }

        protected ParseStorage()
        {
            Appointments = new List<appointment>();
            ParseClient.Initialize(Constants.ApplicationID, Constants.Key);
        }

        ParseObject ToParseObject(appointment appointmnt)
        {
            var po = new ParseObject("appointment");
            if (appointmnt.ID != string.empty)
            {
                po.ObjectId = appointmnt.ID;
            }
            po["title"] = appointmnt.Title;
            po["startdate"] = appointmnt.StartDate;
            po["enddate"] = appointmnt.EndDate;
            po["isallday"] = appointmnt.IsAllDay;
            po["color"] = appointmnt.Color;

            return po;
        }

        static appointment FromParseObject(ParseObject po)
        {
            var a = new appointment();
            a.ID = po.ObjectId;
            a.Title = Convert.ToString(po["title"]);
            a.StartDate = Convert.ToDateTime(po["startdate"]);
            a.EndDate = Convert.ToDateTime(po["enddate"]);
            a.IsAllDay = Convert.ToBoolean(po["isallday"]);
            return a;
        }

        async public Task<List<appointment>> RefreshDataAsync()
        {
            var query = ParseObject.GetQuery("appointment");
            var results = await query.FindAsync();

            var Appointments = new List<appointment>();
            foreach (var appointment in results)
            {
                Appointments.Add(FromParseObject(appointment));
            }

            return Appointments;
        }

        public async Task SaveAppointmentAsync(appointment item)
        {
            try
            {
                await ToParseObject(item).SaveAsync();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(@"Error{0}", e.Message);
            }
        }

        public async Task DeleteAppointmentAsync(appointment item)
        {
            try
            {
                await ToParseObject(item).DeleteAsync();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(@"Error{0}", e.Message);
            }
        }
    }
}


