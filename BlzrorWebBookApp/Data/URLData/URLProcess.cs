using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
namespace BlzrorWebBookApp.Data.URLData
{
	abstract class URLProcessBase
	{
		readonly string _maxResult = "10";
		StringBuilder StrBuilder = new();
		UriBuilder _uriBuilder = new("https://www.googleapis.com/books/v1/volumes?");
		public UriBuilder UriData => _uriBuilder;
		[Pure]
		protected string Connection(string pram, string keword)
		{
			StrBuilder.Clear();
			StrBuilder.Append(pram + keword);
			return StrBuilder.ToString();
		}
		protected NameValueCollection _queeryCollection = HttpUtility.ParseQueryString("");
		protected URLProcessBase()
		{
			NameValueCollection firstQueryForCopy = new()
			{
				["q"] = "",
				["maxResults"] = _maxResult,
				["startIndex"] = "",
			};
			_queeryCollection.Add(firstQueryForCopy);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected void UriQueryConvert()
		{
			UriData.Query = _queeryCollection.ToString();
		}
		
	}
	public interface IQueryConvert
	{
		UriBuilder QueryConvert(string pram, int counter);
	}
}
