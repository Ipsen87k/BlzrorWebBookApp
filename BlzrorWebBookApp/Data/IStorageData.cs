namespace BlzrorWebBookApp.Data
{
	public interface IStorageData :IEnumerable<ReceiveForJsonClass>
	{
		void Add(ReceiveForJsonClass item);
		void Clear();
		ReceiveForJsonClass GetElement(int  index);
	}
}