using Microsoft.AspNetCore.Mvc;

namespace Hackney.Shared.Finance.Boundary.Request
{
    public class PagingParametersRequest
    {
        [FromQuery(Name = "pageSize")]
        public int PageSize { get; set; } = 20;

        [FromQuery(Name = "page")]
        public int PageNumber { get; set; } = 1;
    }
}
