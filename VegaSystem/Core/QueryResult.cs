namespace VegaSystem.Core
{
    using System.Collections.Generic;
    
    public class QueryResult<T>
    {
        public int TotalItems { get; set; }

        public IEnumerable<T> Items { get; set; }
    }
}