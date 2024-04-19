using MediatR;
using Rainfall.Domain.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall.Domain.Dtos.Requests
{
    public class RainfallReadingRequest : IRequest<RainfallReadingResponse>
    {
        public string StationId { get; set; }
        public int? Count { get; set; }
    }
}
