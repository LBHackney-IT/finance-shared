using Hackney.Shared.Finance.Boundary.Response;
using System.Collections.Generic;

namespace Hackney.Shared.Finance.Pagination
{
    public class PaginatedResponse<T>
    {
        public IEnumerable<T> Results { get; set; }
        public MetadataModel Metadata { get; set; }
    }
}
