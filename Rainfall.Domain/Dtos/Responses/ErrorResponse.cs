using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainfall.Domain.Dtos.Responses
{
    public class ErrorResponse
    {
        public List<Error> Errors { get; set; }
    }
}
