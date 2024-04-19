using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall.Domain.Dtos.Responses
{
    public class RainfallReadingResponse
    {
        public List<RainfallReading> Readings { get; set; }
    }
}
