using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointmentShared.Core
{
    public interface IParseStorage
    {
        Task<List<appointment>> RefreshDataAsync();
        Task SaveAppointmentAsync(appointment item);
        Task DeleteAppointmentAsync(appointment id);
    }
}
