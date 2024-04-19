using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall.Domain.Dtos.External
{
    public class GetRainfallReadingsByStationResponseItems
    {
        public string @id { get; set; }
        public DateTime DateTime { get; set; }
        public string Measure { get; set; }
        public double Value { get; set; }
    }
}
