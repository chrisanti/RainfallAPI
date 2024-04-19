using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall.Domain.Dtos.External
{
    public class GetRainfallReadingsByStationResponse
    {
        public string @context { get; set; }
        public GetRainfallReadingsByStationResponseMeta Meta { get; set; }
        public List<GetRainfallReadingsByStationResponseItems> Items { get; set; }
    }
}
