namespace BlzrorWebBookApp.Data
{
	public abstract class BaseSingleton<T> where T : BaseSingleton<T>,ICreateInstace
	{
		protected static T _instance;
		static object _instanceLock = new();
		public static T Instance
		{
			get
			{
				lock (_instanceLock)
				{
					T.CreateInstace();
					return _instance;
				}

			}
		}
		protected BaseSingleton() { }
		protected virtual void Initialize() { }
	}
	public interface ICreateInstace
	{
		abstract static void CreateInstace();
	}
}
