using Hackney.Shared.Finance.Pagination;
using Newtonsoft.Json;

namespace Hackney.Shared.Finance.Boundary.Response
{
    public class MetadataModel
    {
        [JsonProperty("pagination", NullValueHandling = NullValueHandling.Ignore)]
        public PagingDetails Pagination { get; set; }
    }
}
