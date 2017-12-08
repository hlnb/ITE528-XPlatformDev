using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

namespace appointmentShared.Core
{
    public class appointmentManager
    {
        IParseStorage storage;

        public appointmentManager(IParseStorage parseStorage)
        {
            storage = parseStorage;
        }

        public Task<List<appointment>> GetAppointmentAsync()
        {
            return storage.RefreshDataAsync();
        }

        public Task SaveAppointmentAsync(appointment item)
        {
            return storage.SaveAppointmentAsync(item);
        }

        public Task DeleteAppointmentAsync(appointment item)
        {
            return storage.DeleteAppointmentAsync(item);
        }
    }
}
