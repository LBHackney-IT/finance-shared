using Newtonsoft.Json;

namespace Hackney.Shared.Finance.Boundary.Response
{
    public class MetadataModel
    {
        [JsonProperty("pagination", NullValueHandling = NullValueHandling.Ignore)]
        public Pagination Pagination { get; set; }
    }
}
