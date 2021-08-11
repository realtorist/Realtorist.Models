namespace Realtorist.Models.Pagination
{
    /// <summary>
    /// Describes paginated result
    /// </summary>
    /// <typeparam name="T">Type of the returned value array</typeparam>
    public class PaginationResult<T>
    {
        /// <summary>
        /// Number of the total records
        /// </summary>
        public int TotalRecords { get; set; }

        /// <summary>
        /// Number of the total pages
        /// </summary>
        public int TotalPages => TotalRecords == 0 ? 0 : (((int)TotalRecords - 1) / Limit) + 1;

        /// <summary>
        /// Number of the first element in result. Starting from 1
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Number of the max records requested
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Results
        /// </summary>
        public T[] Results;

        /// <summary>
        /// Current page number
        /// </summary>
        public int CurrentPage => Offset / Limit + 1;

        /// <summary>
        /// Number of the returned records
        /// </summary>
        public int RecordsReturned => Results.Length;
    }
}
