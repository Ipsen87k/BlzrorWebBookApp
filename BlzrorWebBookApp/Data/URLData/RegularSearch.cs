using System.Collections.Specialized;
using System.Diagnostics;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace BlzrorWebBookApp.Data.URLData
{
    internal class RegularSearch : URLProcessBase,IQueryConvert
    {
        public UriBuilder QueryConvert(string keyword, int counter)
        {
            _queeryCollection["q"] = keyword;
            _queeryCollection["startIndex"] = counter.ToString();
            UriQueryConvert();
            return UriData;
        }
		public RegularSearch() : base()
		{
            
        }

    }
}
