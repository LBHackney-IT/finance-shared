
namespace Hackney.Shared.Finance.Boundary.Response
{
    public class ApiResponse<T> where T : class
    {
        public T Results { get; set; }

        public long Total { get; set; }

        public ApiResponse() { }

        public ApiResponse(T result)
        {
            Results = result;
        }
    }
}
