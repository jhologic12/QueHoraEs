using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace QueHoraEs
{
    public class TimeZonaService
    {

        public DateTime ObtenerFechadelTimeZone(string timeZoneId)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);
        }
    }
}
