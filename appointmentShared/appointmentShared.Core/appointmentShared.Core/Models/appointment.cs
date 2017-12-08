using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace appointmentShared.Core
{
    public class appointment : IAppointment
    {
        [JsonProperty(PropertyName ="id")]
        public string ID { get; set; }
        [JsonProperty(PropertyName ="enddate")]
        public DateTime EndDate { get; set; }
        [JsonProperty(PropertyName ="startdate")]
        public DateTime StartDate { get; set; }
        [JsonProperty(PropertyName ="title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName ="isallday")]
        public bool IsAllDay { get; set; }
        [JsonProperty(PropertyName ="color")]
        public Color Color { get; set; }

        Color IAppointment.Color
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
