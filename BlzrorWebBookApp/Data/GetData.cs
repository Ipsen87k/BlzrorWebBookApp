using BlzrorWebBookApp.Data.Button;
using BlzrorWebBookApp.Data.URLData;
using System.Diagnostics;


namespace BlzrorWebBookApp.Data
{
    
	public class GetData : IObserver<UserInputData>
    {
        IQueryConvert URL = new RegularSearch();
        ICountable _counter = new Counter(10);
        GetHttpDataSingleton GetHttp=GetHttpDataSingleton.Instance;
        IStorageData storage=StorageData.Instance;
        int count = 0;
        public async Task Update(UserInputData data, int times = 1)
        {      
            for (int i = 0; i < times; i++)
			{
				var uri = URL.QueryConvert(data.BookTitle, _counter.Count);
				storage.Add(await GetHttp.GetLIbraryAPIAsync(uri.Uri));
                _counter.Increment();
            }
        }
    }
}
