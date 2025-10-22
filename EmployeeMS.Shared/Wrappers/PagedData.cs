namespace EmployeeMS.Shared.Wrappers
{
    public class PagedData<T>
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalCount { get; set; }
        public IQueryable<T> Items { get; set; }

        public PagedData(IQueryable<T> items, int pageSize, int pageNumber, int totalCount)
        {
            Items = items;
            PageSize = pageSize;
            PageNumber = pageNumber;
            TotalCount = totalCount;
        }
    }
}
