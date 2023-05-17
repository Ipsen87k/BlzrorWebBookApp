using System.Diagnostics;

namespace BlzrorWebBookApp.Data
{
	public class GetHttpDataSingleton:BaseSingleton<GetHttpDataSingleton>,ICreateInstace
	{
		public Uri URL { get;set; }
		public ReceiveForJsonClass Recever { get; private set; }

		GetHttpDataSingleton() { }
		readonly HttpClient _http = new();
		public async Task<ReceiveForJsonClass> GetLIbraryAPIAsync()
		{
			return await _http.GetFromJsonAsync<ReceiveForJsonClass>(URL);
		}
		public async Task<ReceiveForJsonClass> GetLIbraryAPIAsync(Uri uri)
		{
			return await _http.GetFromJsonAsync<ReceiveForJsonClass>(uri);
		}
		public async Task<ReceiveForJsonClass> GetJsonAsnyc(Uri uri)
		{
			return await _http.GetFromJsonAsync<ReceiveForJsonClass>(uri);
		}

		public static void CreateInstace()
		{
			_instance = new();
		}
	}
}
