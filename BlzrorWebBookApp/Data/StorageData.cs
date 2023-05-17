using System.Collections;
using System.Runtime.CompilerServices;

namespace BlzrorWebBookApp.Data
{
	public sealed class StorageData :BaseSingleton<StorageData>, IStorageData,ICreateInstace
	{
		HashSet<ReceiveForJsonClass> _receiveForJsonClasseDatas = new();

		StorageData() { }
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(ReceiveForJsonClass item) => _receiveForJsonClasseDatas.Add(item);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear() => _receiveForJsonClasseDatas.Clear();

		public ReceiveForJsonClass GetElement(int index)
		{
			return index > _receiveForJsonClasseDatas.Count ? null : _receiveForJsonClasseDatas.ElementAt(index);
		}

		public IEnumerator<ReceiveForJsonClass> GetEnumerator()
		{
			return ((IEnumerable<ReceiveForJsonClass>)_receiveForJsonClasseDatas).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)_receiveForJsonClasseDatas).GetEnumerator();
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CreateInstace()
		{
			_instance ??= new();
		}
	}
}
