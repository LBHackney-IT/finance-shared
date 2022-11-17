namespace Hackney.Shared.Finance.Pagination
{
    public class PagingDetails
    {
        public int ResultCount { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int PageCount { get; set; }
    }
}
