﻿
namespace Hackney.Shared.Finance.Boundary.Response
{
    public class PagingParametersDomain
    {
        public int PageSize { get; set; } = 20;
        public int PageNumber { get; set; } = 1;
    }
}
